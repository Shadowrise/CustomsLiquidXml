using System;
using CustomsLiquidXml.XSD.Arm;
using CustomsLiquidXml.XSD.ESADoutCU;
using LiquidTechnologies.XmlObjects;

namespace CustomsLiquidXml
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = "Examples/ESADout_CU.xml";

            var serializer = new LxSerializer<ESADout_CUElm>();

            Console.WriteLine("Deserialization started...");
            ESADout_CUElm company = serializer.Deserialize(path, GetReaderSettings());
            Console.WriteLine();

            // error 1: min length = 1
            company.DocumentModeID = "";
            // error 2: length = 2
            company.CustomsProcedure = "123";

            Console.WriteLine("Serialization started...");
            serializer.Serialize("out.xml", company, GetWriterSettings());
            Console.ReadKey();
        }

        public static LxReaderSettings GetReaderSettings() => new LxReaderSettings()
        {
            ErrorHandler = (string msg, LxErrorSeverity severity, LxErrorCode errorCode, TextLocation location, object targetObject) =>
            {
                Console.WriteLine($"{severity}:{errorCode}:{location} {msg}");

                // throwing an exception will stop de-serialization
                // if (severity == LxErrorSeverity.Error)
                    // throw new LxSerializationException(msg, severity, errorCode, location, targetObject);

                // returning will cause the warning/error to be ignored and serialization will continue
            }
        };
        public static LxWriterSettings GetWriterSettings() => new LxWriterSettings()
        {
            ErrorHandler = (string msg, LxErrorSeverity severity, LxErrorCode errorCode, object targetObject) =>
            {
                Console.WriteLine($"{severity}:{errorCode} {msg}");

                // throwing an exception will stop Serialization
                //if (severity == LxErrorSeverity.Error)
                //   throw new LxSerializationException(msg, severity, errorCode, null, targetObject);

                // returning will cause the warning/error to be ignored and serialization will continue
            }
        };

    }
}
