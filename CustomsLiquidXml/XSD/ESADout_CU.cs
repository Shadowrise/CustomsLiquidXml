///////////////////////////////////////////////////////////////////////////
//           Liquid XML Objects GENERATED CODE - DO NOT MODIFY           //
//            https://www.liquid-technologies.com/xml-objects            //
//=======================================================================//
// Dependencies                                                          //
//     Nuget : LiquidTechnologies.XmlObjects.Runtime                     //
//           : MUST BE VERSION 18.0.5                                    //
//=======================================================================//
// Online Help                                                           //
//     https://www.liquid-technologies.com/xml-objects-quick-start-guide //
//=======================================================================//
// Licensing Information                                                 //
//     https://www.liquid-technologies.com/eula                          //
///////////////////////////////////////////////////////////////////////////
using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;
using System.Numerics;
using LiquidTechnologies.XmlObjects;
using LiquidTechnologies.XmlObjects.Attribution;

// ------------------------------------------------------
// |                      Settings                      |
// ------------------------------------------------------
// GenerateCommonBaseClass                  = False
// GenerateUnprocessedNodeHandlers          = False
// RaiseChangeEvents                        = False
// CollectionNaming                         = Pluralize
// Language                                 = CS
// OutputNamespace                          = CustomsLiquidXml.XSD
// WriteDefaultValuesForOptionalAttributes  = True
// WriteDefaultValuesForOptionalElements    = False
// GenerationModel                          = Simple
//                                            *WARNING* this simplified model that is very easy to work with
//                                            but may cause the XML to be produced without regard for element
//                                            cardinality or order. Where very high compliance with the XML Schema
//                                            standard is required use GenerationModelType.Conformant
// XSD Schema Files
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CategoriesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonLeafTypesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonLeafTypesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonLeafTypes.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd


namespace CustomsLiquidXml.XSD
{
    #region Global Settings
    /// <summary>Contains library level properties, and ensures the version of the runtime used matches the version used to generate it.</summary>
    [LxRuntimeRequirements("18.0.5.9988", "Trial for Non-Commercial Use Expiry [2020-05-12]", "PWTE2G9KY1QJ9PJ3", LiquidTechnologies.XmlObjects.LicenseTermsType.Trial)]
    public partial class LxRuntimeRequirementsWritten
    {
    }

    #endregion

}

namespace CustomsLiquidXml.XSD.CltRu
{
    #region Enumerations
    /// <summary>An enumeration representing XSD simple type TransportCategoryCodeType@urn:customs.ru:CommonLeafTypes:5.10.0</summary>
    /// <remarks>Категория транспортного средства. Допустимые значения: A,B,C,D,E (латинские символы). 1 символ</remarks>
    /// <XsdPath>schema:CommonLeafTypesCust.xsd/simpleType:TransportCategoryCodeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonLeafTypesCust.xsd</XsdFile>
    /// <XsdLocation>1300:2-1311:18</XsdLocation>
    public enum TransportCategoryCodeTypeEnum
    {
        /// <summary>Represents the value 'A' in the XML</summary>
        [LxEnumValue("A")]
        A,
        /// <summary>Represents the value 'B' in the XML</summary>
        [LxEnumValue("B")]
        B,
        /// <summary>Represents the value 'C' in the XML</summary>
        [LxEnumValue("C")]
        C,
        /// <summary>Represents the value 'D' in the XML</summary>
        [LxEnumValue("D")]
        D,
        /// <summary>Represents the value 'E' in the XML</summary>
        [LxEnumValue("E")]
        E,
    }
    #endregion

}

namespace CustomsLiquidXml.XSD.Xs
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType anyType@http://www.w3.org/2001/XMLSchema</summary>
    /// <XsdPath>schema:.../www.w3.org/2001/XMLSchema/complexType:anyType</XsdPath>
    /// <XsdFile>http://www.w3.org/2001/XMLSchema</XsdFile>
    /// <XsdLocation>Empty</XsdLocation>
    [LxSimpleComplexTypeDefinition("anyType", "http://www.w3.org/2001/XMLSchema")]
    public partial class AnyTypeCt : XElement
    {
        /// <summary>Constructor : create a <see cref="AnyTypeCt" /> element &lt;anyType xmlns='http://www.w3.org/2001/XMLSchema'&gt;</summary>
        public AnyTypeCt()  : base(XName.Get("anyType", "http://www.w3.org/2001/XMLSchema")) { }

    }

    #endregion

}

namespace CustomsLiquidXml.XSD.CatRu
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType AddressType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Адрес организации / физического лица</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:AddressType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>7:2-48:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AddressType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class AddressTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Почтовый индекс</remarks>
        [LxElementValue("PostalCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String PostalCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое название страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CounryName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CounryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Область (регион, штат, провинция и т.п.)</remarks>
        [LxElementValue("Region", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String Region { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Населенный пункт</remarks>
        [LxElementValue("City", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "35")]
        public System.String City { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Улица, номер дома, номер офиса</remarks>
        [LxElementValue("StreetHouse", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String StreetHouse { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориальной единицы в соответствии с ГК СОАТЕ (для Кыргызской Республики)</remarks>
        [LxElementValue("TerritoryCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{8,17}")]
        public System.String TerritoryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AuthoritesDocumentType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения о документе, удостоверяющем полномочия</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:AuthoritesDocumentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>49:2-64:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AuthoritesDocumentType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class AuthoritesDocumentTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания полномочий</remarks>
        [LxElementValue("ComplationAuthorityDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ComplationAuthorityDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AutomobileBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Данные об автомобилях. Базовый класс для 31й гр. и  Карточки транспортного средства</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:AutomobileBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>65:2-126:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AutomobileBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class AutomobileBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Марка, модель</remarks>
        [LxElementValue("Model", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "100")]
        public System.String Model { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование марки транспортного средства в соответствии с классификатором марок дорожных транспортных средств</remarks>
        [LxElementValue("Mark", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String Mark { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код марки транспортного средства в соответствии с классификатором марок дорожных транспортных средств</remarks>
        [LxElementValue("MarkCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String MarkCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Год изготовления транспортного средства</remarks>
        [LxElementValue("OfftakeYear", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdGYear, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? OfftakeYear { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Рабочий объем двигателя, куб. см</remarks>
        [LxElementValue("EngineVolumeQuanity", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "6", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? EngineVolumeQuanity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер (VIN)</remarks>
        [LxElementValue("VINID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String VINID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер кузова (прицепа), присвоенный и нанесенный на него организацией-изготовителем</remarks>
        [LxElementValue("BodyID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String BodyID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Присвоенный организацией - изготовителем идентификационный номер двигателя, нанесенный на блоке двигателя. Идентификационный номер может состоять из групп раздельных цифр, из которых последняя группа, состоящая из двух цифр, указывает год выпуска двигателя</remarks>
        [LxElementValue("EngineID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String EngineID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер шасси (рамы), присвоенные и нанесенные на них организацией-изготовителем</remarks>
        [LxElementValue("ChassisID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String ChassisID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер кабины</remarks>
        [LxElementValue("CabID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CabID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер устройства или системы вызова экстренных оперативных служб, которыми оборудовано транспортное средство. Для РФ</remarks>
        [LxElementValue("EmergencyDeviceID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String EmergencyDeviceID { get; set; }

    }

    /// <summary>A class representing the root XSD complexType BankInformationType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Информация о банковских счетах</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:BankInformationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>127:2-183:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("BankInformationType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class BankInformationTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Номер банковского счета</remarks>
        [LxElementValue("BankAccount", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> BankAccounts { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание типа счета: расчетный, валютный</remarks>
        [LxElementValue("BankAccountDescription", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> BankAccountDescriptions { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Название банка</remarks>
        [LxElementValue("BankName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String BankName { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>МФО банка</remarks>
        [LxElementValue("BankMFO", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String BankMFO { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код банка по ОКПО</remarks>
        [LxElementValue("OKPOID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String OKPOID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>БИК банка</remarks>
        [LxElementValue("BICID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String BICID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>SWIFT код банка</remarks>
        [LxElementValue("SWIFTID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "8", MaxLength = "11")]
        public System.String SWIFTID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер корреспондентского счета банка</remarks>
        [LxElementValue("CorrAccount", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String CorrAccount { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Валютный счет организации (транзитный)</remarks>
        [LxElementValue("TransitCurrencyAccount", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> TransitCurrencyAccounts { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Валютный счет организации (специальный транзитный)</remarks>
        [LxElementValue("SpecialTransitCurrencyAccount", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> SpecialTransitCurrencyAccounts { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType BaseDocType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Базовый тип для электронного документа</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:BaseDocType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>184:2-200:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("BaseDocType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class BaseDocTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Уникальный идентификатор документа</remarks>
        [LxElementValue("DocumentID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String DocumentID { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор исходного документа</remarks>
        [LxElementValue("RefDocumentID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String RefDocumentID { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CargoBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения о грузе</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CargoBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>304:2-320:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CargoBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CargoBaseTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание груза</remarks>
        [LxElementValue("CargoDescription", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> CargoDescriptions { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара брутто (кг)</remarks>
        [LxElementValue("GrossWeightQuantity", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? GrossWeightQuantity { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ContactType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Контактная информация</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:ContactType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>321:2-347:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ContactType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class ContactTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Номер телефона</remarks>
        [LxElementValue("Phone", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "24")]
        public List<System.String> Phones { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер факса</remarks>
        [LxElementValue("Fax", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "24")]
        public System.String Fax { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер телекса</remarks>
        [LxElementValue("Telex", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "24")]
        public System.String Telex { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Адрес электронной почты</remarks>
        [LxElementValue("E_mail", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> E_Mails { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType CUBranchDescriptionType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об обособленном подразделении</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CUBranchDescriptionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>201:2-244:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUBranchDescriptionType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CUBranchDescriptionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Краткое наименование обособленного подразделения</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String OrganizationName { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес обособленного подразделения</remarks>
        [LxElementCt("Address", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AddressTypeCt Address { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
        [LxElementCt("RKOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt RKOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
        [LxElementCt("RBOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt RBOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
        [LxElementCt("RAOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt RAOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
        [LxElementCt("KGOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt KGOrganizationFeatures { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUCustomsType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения о таможенном органе</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CUCustomsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>245:2-260:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUCustomsType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CUCustomsTypeCt : CustomsLiquidXml.XSD.CatRu.CustomsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код государства - члена Евразийского экономического союза. Трехзначный цифровой код</remarks>
        [LxElementValue("CustomsCountryCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String CustomsCountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUOrganizationType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации  (используется до версии АФ 5.14.3)</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CUOrganizationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>261:2-286:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUOrganizationType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CUOrganizationTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес организации</remarks>
        [LxElementCt("Address", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AddressTypeCt Address { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt IdentityCard { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактная информация</remarks>
        [LxElementCt("Contact", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt Contact { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CustomsPersonType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Должностное лицо таможенного органа</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CustomsPersonType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>348:2-364:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CustomsPersonType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CustomsPersonTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>ФИО должностного лица таможенного органа</remarks>
        [LxElementValue("PersonName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonName { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ЛНП должностного лица таможенного органа</remarks>
        [LxElementValue("LNP", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String LNP { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CustomsType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Код и наименование таможенного органа</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CustomsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>365:2-381:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CustomsType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CustomsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа</remarks>
        [LxElementValue("Code", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String Code { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование таможенного органа</remarks>
        [LxElementValue("OfficeName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String OfficeName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUTransportMeansType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Транспортные средства на границе / внутри страны</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:CUTransportMeansType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>287:2-303:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUTransportMeansType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class CUTransportMeansTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида транспортного средства по классификатору видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransportModeCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String TransportModeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны принадлежности (регистрации) транспортных средств по классификатору стран мира. 99-разные, 00-неизвестна</remarks>
        [LxElementValue("TransportNationalityCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String TransportNationalityCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DeliveryTermsRUType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Условие поставки товаров. Для России</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:DeliveryTermsRUType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>382:2-398:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeliveryTermsRUType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class DeliveryTermsRUTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Описание / Название географического пункта</remarks>
        [LxElementValue("DeliveryPlace", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DeliveryPlace { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код условий поставки в соответствии с классификатором условий поставки</remarks>
        [LxElementValue("DeliveryTermsStringCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\D{3}")]
        public System.String DeliveryTermsStringCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DeliveryTermsType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Условие поставки товаров</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:DeliveryTermsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>399:2-425:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeliveryTermsType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class DeliveryTermsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Описание / Название географического пункта</remarks>
        [LxElementValue("DeliveryPlace", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DeliveryPlace { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код условий поставки в соответствии с классификатором условий поставки</remarks>
        [LxElementValue("DeliveryTermsStringCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\D{3}")]
        public System.String DeliveryTermsStringCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида поставки товаров в соответствии с классификатором видов поставок товаров, подлежащих учету при осуществлении экспортных операций, применяемым в Республике Беларусь</remarks>
        [LxElementValue("DeliveryTermsRBCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String DeliveryTermsRBCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Место передачи товара в соответствии с условиями договора (контракта)</remarks>
        [LxElementValue("TransferPlace", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String TransferPlace { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DimensionsType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Габариты</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:DimensionsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>426:2-452:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DimensionsType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class DimensionsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код единицы измерения</remarks>
        [LxElementValue("DimensionsCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String DimensionsCode { get; set; } = "";

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Длина</remarks>
        [LxElementValue("Lenght", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5")]
        public System.Numerics.BigInteger Lenght { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Ширина</remarks>
        [LxElementValue("Wight", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5")]
        public System.Numerics.BigInteger Wight { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Высота</remarks>
        [LxElementValue("Height", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5")]
        public System.Numerics.BigInteger Height { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocumentBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Базовый класс для указания документов. Наименование, номер, дата</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:DocumentBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>453:2-474:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocumentBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование документа</remarks>
        [LxElementValue("PrDocumentName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String PrDocumentName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер документа</remarks>
        [LxElementValue("PrDocumentNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String PrDocumentNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата документа</remarks>
        [LxElementValue("PrDocumentDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? PrDocumentDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DriverInformationType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Информация о водителях транспортных средств. Заполняется при транзите товаров автомобильным транспортом (используется до версии АФ 5.14.3)</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:DriverInformationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>475:2-495:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DriverInformationType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class DriverInformationTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны регистрации водителя транспортного средства</remarks>
        [LxElementValue("RegCountryCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String RegCountryCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt IdentityCard { get; set; } = new CustomsLiquidXml.XSD.CatRu.IdentityCardTypeCt();

    }

    /// <summary>A class representing the root XSD complexType GoodsBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Базовый тип описания товара</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:GoodsBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>562:2-593:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class GoodsBaseTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Номер товара по порядку</remarks>
        [LxElementValue("GoodsNumeric", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger GoodsNumeric { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара по ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("GoodsTNVEDCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4,10}")]
        public System.String GoodsTNVEDCode { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание товара</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара брутто (кг)</remarks>
        [LxElementValue("GrossWeightQuantity", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? GrossWeightQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара нетто (кг)</remarks>
        [LxElementValue("NetWeightQuantity", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeightQuantity { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GTDID5Type@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Регистрационный номер таможенного документа. Применяется для всех документов, имеющих структуру номера, аналогичную структуре номера ДТ. Последний элемент 5 знаков</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:GTDID5Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>496:2-517:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GTDID5Type", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class GTDID5TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа, зарегистрировавшего документ</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата регистрации документа</remarks>
        [LxElementValue("RegistrationDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime RegistrationDate { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Порядковый номер документа по журналу регистрации</remarks>
        [LxElementValue("SerialNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "5")]
        public System.String SerialNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType GTDID6Type@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Регистрационный номер таможенного документа. Применяется для всех документов, имеющих структуру номера, аналогичную структуре номера ДТ. Последний элемент 6 знаков</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:GTDID6Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>518:2-539:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GTDID6Type", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class GTDID6TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа, зарегистрировавшего документ</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата регистрации документа</remarks>
        [LxElementValue("RegistrationDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime RegistrationDate { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Порядковый номер документа по журналу регистрации</remarks>
        [LxElementValue("SerialNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "6")]
        public System.String SerialNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType GTDIDType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Регистрационный номер таможенного документа. Применяется для всех документов, имеющих структуру номера, совпадающую со структурой номера ДТ</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:GTDIDType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>540:2-561:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GTDIDType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class GTDIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа, зарегистрировавшего документ</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата регистрации документа</remarks>
        [LxElementValue("RegistrationDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime RegistrationDate { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Порядковый номер документа по журналу регистрации</remarks>
        [LxElementValue("GTDNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String GTDNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType IdentityCardType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Документ, удостоверяющий личность (используется до версии АФ 5.14.3)</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:IdentityCardType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>621:2-657:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentityCardType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class IdentityCardTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа, удостоверяющего личность. Для РФ</remarks>
        [LxElementValue("IdentityCardCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{2}")]
        public System.String IdentityCardCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "15")]
        public System.String IdentityCardName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Серия документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardSeries", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "11")]
        public System.String IdentityCardSeries { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String IdentityCardNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата выдачи документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? IdentityCardDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организации, выдавшей документ</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String OrganizationName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ITNKZType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Идентификационный таможенный номер (ИТН) Республика Казахстан</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:ITNKZType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>594:2-620:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ITNKZType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class ITNKZTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Категория лица. Двухзначный цифровой код категории лица согласно учредительным документам или свидетельству о регистрации в качестве индивидуального предпринимателя</remarks>
        [LxElementValue("CategoryCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String CategoryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код КАТО. Двухзначный код КАТО в соответствии с классификатором кодов административно-территориальных объектов</remarks>
        [LxElementValue("KATOCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String KATOCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>РНН. Регистрационный налоговый номер, присваиваемый налоговыми органами Республики Казахстан</remarks>
        [LxElementValue("RNN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "12")]
        public System.String RNN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Резерв для ИТН</remarks>
        [LxElementValue("ITNReserv", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String ITNReserv { get; set; }

    }

    /// <summary>A class representing the root XSD complexType KGOrganizationFeaturesType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:KGOrganizationFeaturesType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>658:2-674:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("KGOrganizationFeaturesType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class KGOrganizationFeaturesTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ИНН - идентификационный налоговый номер налогоплательщика, ПИН - персональный идентификационный номер</remarks>
        [LxElementValue("KGINN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{14}")]
        public System.String KGINN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код Общереспубликанского классификатора предприятий и организаций (ОКПО) для юридических лиц и индивидуальных предпринимателей</remarks>
        [LxElementValue("KGOKPO", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{8}")]
        public System.String KGOKPO { get; set; }

    }

    /// <summary>A class representing the root XSD complexType NewClassType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:NewClassType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>675:2-675:39</XsdLocation>
    [LxSimpleComplexTypeDefinition("NewClassType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class NewClassTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType OrganizationBackAddrType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации.  Юридический и фактический адрес</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:OrganizationBackAddrType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>676:2-691:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("OrganizationBackAddrType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class OrganizationBackAddrTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />
        /// </summary>
        /// <remarks>Фактический адрес организации</remarks>
        [LxElementCt("FactAddress", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AddressTypeCt FactAddress { get; set; }

    }

    /// <summary>A class representing the root XSD complexType OrganizationBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Реквизиты организации. Базовый класс</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:OrganizationBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>692:2-740:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("OrganizationBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организации / ФИО физического лица</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String OrganizationName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование организации</remarks>
        [LxElementValue("ShortName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String ShortName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код языка для заполнения наименования</remarks>
        [LxElementValue("OrganizationLanguage", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}")]
        public System.String OrganizationLanguage { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
        [LxElementCt("RKOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt RKOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
        [LxElementCt("RBOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt RBOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
        [LxElementCt("RAOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt RAOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
        [LxElementCt("KGOrganizationFeatures", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt KGOrganizationFeatures { get; set; }

    }

    /// <summary>A class representing the root XSD complexType OrganizationType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:OrganizationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>741:2-771:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("OrganizationType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class OrganizationTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код организации по ОКПО</remarks>
        [LxElementValue("OKPOID", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String OKPOID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код ОКАТО</remarks>
        [LxElementValue("OKATOCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{5,11}")]
        public System.String OKATOCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес</remarks>
        [LxElementCt("Address", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AddressTypeCt Address { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактная информация</remarks>
        [LxElementCt("Contact", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt Contact { get; set; }

    }

    /// <summary>A class representing the root XSD complexType OrganizationWBankType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации, включая банковские счета</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:OrganizationWBankType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>772:2-787:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("OrganizationWBankType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class OrganizationWBankTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt" />
        /// </summary>
        /// <remarks>Информация о банковских счетах.</remarks>
        [LxElementCt("BankInformation", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt> BankInformations { get; } = new List<CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType PersonBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Базовый класс для указания сведений о должностном лице. ФИО, должность</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:PersonBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>788:2-814:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PersonBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class PersonBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Фамилия</remarks>
        [LxElementValue("PersonSurname", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonSurname { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Имя</remarks>
        [LxElementValue("PersonName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonName { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Отчество</remarks>
        [LxElementValue("PersonMiddleName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonMiddleName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Должность</remarks>
        [LxElementValue("PersonPost", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String PersonPost { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PersonSignatureType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Подпись</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:PersonSignatureType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>815:2-830:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PersonSignatureType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class PersonSignatureTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата подписания</remarks>
        [LxElementValue("IssueDate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? IssueDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RAOrganizationFeaturesType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:RAOrganizationFeaturesType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>831:2-852:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RAOrganizationFeaturesType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class RAOrganizationFeaturesTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Учетный номер налогоплательщика (УНН)</remarks>
        [LxElementValue("UNN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{8}")]
        public System.String UNN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номерной знак общественных услуг (НЗОУ)</remarks>
        [LxElementValue("SocialServiceNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{10}")]
        public System.String SocialServiceNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер справки об отсутствии номерного знака общественных услуг (НЗОУ)</remarks>
        [LxElementValue("SocialServiceCertificate", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "10")]
        public System.String SocialServiceCertificate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RBOrganizationFeaturesType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:RBOrganizationFeaturesType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>853:2-869:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RBOrganizationFeaturesType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class RBOrganizationFeaturesTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Учетный номер плательщика (УНП)</remarks>
        [LxElementValue("UNP", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String UNP { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер физического лица</remarks>
        [LxElementValue("RBIdentificationNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "14")]
        public System.String RBIdentificationNumber { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RFOrganizationFeaturesType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:RFOrganizationFeaturesType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>870:2-891:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RFOrganizationFeaturesType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class RFOrganizationFeaturesTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ОГРН/ОГРНИП. Основной государственный регистрационный номер</remarks>
        [LxElementValue("OGRN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "(\\d{15})|(\\d{13})")]
        public System.String OGRN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ИНН - Индивидуальный номер налогоплательщика</remarks>
        [LxElementValue("INN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "10", MaxLength = "12")]
        public System.String INN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>КПП - Код причины постановки на учет</remarks>
        [LxElementValue("KPP", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String KPP { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RKOrganizationFeaturesType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:RKOrganizationFeaturesType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>892:2-913:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RKOrganizationFeaturesType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class RKOrganizationFeaturesTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Бизнес-идентификационный номер (БИН)</remarks>
        [LxElementValue("BIN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{12}")]
        public System.String BIN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Индивидуальный идентификационный номер (ИИН)</remarks>
        [LxElementValue("IIN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{12}")]
        public System.String IIN { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ITNKZTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ITNKZTypeCt" />
        /// </summary>
        /// <remarks>Идентификационный таможенный номер (ИТН)</remarks>
        [LxElementCt("ITN", "urn:customs.ru:CommonAggregateTypes:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ITNKZTypeCt ITN { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SupplementaryQuantityType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Количество в дополнительной единице измерения</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:SupplementaryQuantityType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>914:2-935:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SupplementaryQuantityType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class SupplementaryQuantityTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Количество товара в единице измерения</remarks>
        [LxElementValue("GoodsQuantity", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal GoodsQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Условное обозначение единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierName", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String MeasureUnitQualifierName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения в соответствии с единицами измерения, применяемыми в ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("MeasureUnitQualifierCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String MeasureUnitQualifierCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TransportGoodsBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Описание товаров. Базовый</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:TransportGoodsBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>936:2-952:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransportGoodsBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class TransportGoodsBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер и марка груза</remarks>
        [LxElementValue("GoodsMarking", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String GoodsMarking { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование груза</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType TransportMeansBaseType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Базовый тип для описания транспортного средства в таможенных документах</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:TransportMeansBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>953:2-994:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransportMeansBaseType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class TransportMeansBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер шасси (VIN)</remarks>
        [LxElementValue("VIN", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String VIN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа транспортного средства</remarks>
        [LxElementValue("TransportKindCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String TransportKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код марки транспортного средства</remarks>
        [LxElementValue("TransportMarkCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String TransportMarkCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор. Номер транспортного средства, наименование судна, номер авиарейса, номер поезда, номер железнодорожного вагона (платформ, цистерн и т.п.)</remarks>
        [LxElementValue("TransportIdentifier", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String TransportIdentifier { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны принадлежности транспортного средства по классификатору стран мира</remarks>
        [LxElementValue("TransportMeansNationalityCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String TransportMeansNationalityCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор активного транспортного средства для прицепов, полуприцепов и др. (Резерв)</remarks>
        [LxElementValue("ActiveTransportIdentifier", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String ActiveTransportIdentifier { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер свидетельства о регистрации транспортного средства для РБ</remarks>
        [LxElementValue("TransportRegNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String TransportRegNumber { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TransportMeansPassportType@urn:customs.ru:CommonAggregateTypes:5.10.0</summary>
    /// <remarks>Серия и номер Паспорта транспортного средства</remarks>
    /// <XsdPath>schema:CommonAggregateTypesCust.xsd/complexType:TransportMeansPassportType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>995:2-1016:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransportMeansPassportType", "urn:customs.ru:CommonAggregateTypes:5.10.0")]
    public partial class TransportMeansPassportTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Серия Паспорта транспортного средства</remarks>
        [LxElementValue("Series", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "([А-Я]{2})")]
        public System.String Series { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер Паспорта транспортного средства</remarks>
        [LxElementValue("PTSNumber", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{6}|[0-9]{7}")]
        public System.String PTSNumber { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код региона</remarks>
        [LxElementValue("RegionCode", "urn:customs.ru:CommonAggregateTypes:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "(\\d{3})|(\\d{2})")]
        public System.String RegionCode { get; set; } = "";

    }

    #endregion

}

namespace CustomsLiquidXml.XSD.CatESADCu
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType AEORegistryIdDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе, подтверждающем включение лица в реестр таможенных перевозчиков или в реестр уполномоченных экономических операторов</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:AEORegistryIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>9:2-40:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AEORegistryIdDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class AEORegistryIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа реестра уполномоченных экономических операторов</remarks>
        [LxElementValue("RegistryOwnerCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RegistryOwnerCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер свидетельства, присвоенный уполномоченным органом государства-члена</remarks>
        [LxElementValue("DocId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DocId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа свидетельства уполномоченного экономического оператора</remarks>
        [LxElementValue("AEORegistryKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String AEORegistryKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение признака перерегистрации документа</remarks>
        [LxElementValue("ReregistrationCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String ReregistrationCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AutomobileBaseType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Данные об автомобилях. Базовый класс для 31й гр. и  Карточки транспортного средства</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:AutomobileBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>41:2-102:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AutomobileBaseType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class AutomobileBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование модели транспортного средства</remarks>
        [LxElementValue("Model", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "100")]
        public System.String Model { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование марки транспортного средства в соответствии с классификатором марок дорожных транспортных средств</remarks>
        [LxElementValue("Mark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String Mark { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код марки транспортного средства в соответствии с классификатором марок дорожных транспортных средств</remarks>
        [LxElementValue("MarkCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String MarkCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Год изготовления транспортного средства</remarks>
        [LxElementValue("OfftakeYear", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdGYear, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? OfftakeYear { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Рабочий объем двигателя</remarks>
        [LxElementCt("EngineVolumeQuanity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt EngineVolumeQuanity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер (VIN)</remarks>
        [LxElementValue("VINID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String VINID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер кузова (прицепа), присвоенный и нанесенный на него организацией-изготовителем</remarks>
        [LxElementValue("BodyID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String BodyID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Присвоенный организацией - изготовителем идентификационный номер двигателя, нанесенный на блоке двигателя. Идентификационный номер может состоять из групп раздельных цифр, из которых последняя группа, состоящая из двух цифр, указывает год выпуска двигателя</remarks>
        [LxElementValue("EngineID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String EngineID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер шасси (рамы), присвоенные и нанесенные на них организацией-изготовителем</remarks>
        [LxElementValue("ChassisID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String ChassisID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер кабины</remarks>
        [LxElementValue("CabID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CabID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер устройства или системы вызова экстренных оперативных служб, которыми оборудовано транспортное средство. Для РФ</remarks>
        [LxElementValue("EmergencyDeviceID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String EmergencyDeviceID { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AutomobileType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об автомобилях. Гр. 31</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:AutomobileType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>103:2-133:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AutomobileType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class AutomobileTypeCt : CustomsLiquidXml.XSD.CatESADCu.AutomobileBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер удостоверения</remarks>
        [LxElementValue("IdentityCardNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String IdentityCardNumber { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CarCostInfoTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CarCostInfoTypeCt" />
        /// </summary>
        /// <remarks>Сведения о cтоимости транспортного средства</remarks>
        [LxElementCt("CarCostInfo", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CarCostInfoTypeCt CarCostInfo { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Максимальная мощность двигателя</remarks>
        [LxElementCt("EngineMaxPowerMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt> EngineMaxPowerMeasures { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Пробег</remarks>
        [LxElementCt("PassedKilometerQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt PassedKilometerQuantity { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CarCostInfoType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о cтоимости транспортного средства</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CarCostInfoType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>134:2-150:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CarCostInfoType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CarCostInfoTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Стоимость транспортного средства</remarks>
        [LxElementValue("CarCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal CarCost { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Трехзначный буквенный код валюты стоимости транспортного средства в соответствии с Классификатором валют</remarks>
        [LxElementValue("CarCostCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String CarCostCurrencyCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType CIMIdDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об идентификационных номерах (идентификаторах) нанесенных контрольных (идентификационных) знаков</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CIMIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>151:2-177:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CIMIdDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CIMIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак нанесения контрольных (идентификационных) знаков после выпуска товаров «ПВ»</remarks>
        [LxElementValue("CIMMarkingFlag", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String CIMMarkingFlag { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество нанесенных контрольных (идентификационных) знаков</remarks>
        [LxElementValue("CIMQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "10")]
        public System.Numerics.BigInteger? CIMQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMListTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMListTypeCt" />
        /// </summary>
        /// <remarks>Перечень идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
        [LxElementCt("CIMList", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CIMListTypeCt CIMList { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMRangeTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMRangeTypeCt" />
        /// </summary>
        /// <remarks>Диапазон идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
        [LxElementCt("CIMRange", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CIMRangeTypeCt> CIMRanges { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CIMRangeTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType CIMListType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Перечень идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CIMListType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>178:2-189:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CIMListType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CIMListTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Идентификационный номер (идентификатор) контрольного (идентификационного) знака</remarks>
        [LxElementValue("CIMID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, Pattern = "[A-Z]{2}-[A-Z0-9]{6}-[A-Z0-9]{10}")]
        public List<System.String> CIMIDS { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType CIMRangeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Диапазон идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CIMRangeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>190:2-206:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CIMRangeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CIMRangeTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Первый номер диапазона идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
        [LxElementValue("FirstCIMID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}-[A-Z0-9]{6}-[A-Z0-9]{10}")]
        public System.String FirstCIMID { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Последний номер диапазона идентификационных номеров (идентификаторов) контрольных (идентификационных) знаков</remarks>
        [LxElementValue("LastCIMID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}-[A-Z0-9]{6}-[A-Z0-9]{10}")]
        public System.String LastCIMID { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType ComponentDescriptionType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Описание функционального блока или компоненты</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ComponentDescriptionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>207:2-238:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ComponentDescriptionType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ComponentDescriptionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код  по ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("GoodsTNVEDCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4,10}")]
        public System.String GoodsTNVEDCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Количество в кг</remarks>
        [LxElementValue("KGWeight", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? KGWeight { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Цена товара /Фактурная стоимость</remarks>
        [LxElementValue("InvoicedCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? InvoicedCost { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код валюты фактурной стоимости</remarks>
        [LxElementValue("InvoiceCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String InvoiceCurrencyCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество в дополнительной единице измерения</remarks>
        [LxElementCt("SupplementaryQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt SupplementaryQuantity { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ComponentsListType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Поставка компонентами - Список компонентов</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ComponentsListType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>239:2-250:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ComponentsListType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ComponentsListTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.MechanismUnitTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.MechanismUnitTypeCt" />
        /// </summary>
        /// <remarks>Сведения о функциональном блоке или компоненте товара</remarks>
        [LxElementCt("MechanismUnit", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.MechanismUnitTypeCt> MechanismUnits { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.MechanismUnitTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ContainerNumberType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Номер контейнера</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ContainerNumberType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>251:2-267:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ContainerNumberType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ContainerNumberTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер (идентификатор) контейнера</remarks>
        [LxElementValue("ContainerIdentificaror", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "17")]
        public System.String ContainerIdentificaror { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак заполнения контейнера. 1 - товар занимает весь контейнер, 2- товар занимает часть контейнера</remarks>
        [LxElementValue("FullIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String FullIndicator { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ContractCostType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Валюта и общая стоимость по счету. Гр. 22, 23</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ContractCostType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>268:2-299:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ContractCostType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ContractCostTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Трехзначный буквенный в графе 22 код валюты цены договора/ платежа (оценки). По классификатору валют</remarks>
        [LxElementValue("ContractCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String ContractCurrencyCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество единиц валюты, для которой указан курс для РБ</remarks>
        [LxElementValue("CurrencyQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "6")]
        public System.Numerics.BigInteger? CurrencyQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Курс валюты цены договора (контракта) или валюты платежа (оценки)</remarks>
        [LxElementValue("ContractCurrencyRate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "11", FractionDigits = "4")]
        public LiquidTechnologies.XmlObjects.BigDecimal? ContractCurrencyRate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общая стоимость товаров. Гр 22 подраздел 2</remarks>
        [LxElementValue("TotalInvoiceAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalInvoiceAmount { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общая стоимость товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде</remarks>
        [LxElementValue("TotalAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalAmount { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CountryDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о стране</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CountryDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>300:2-321:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CountryDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CountryDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны происхождения в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны назначения в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь</remarks>
        [LxElementValue("RBCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBCountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CU_ElectricalEnergyType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о количестве принятой и переданной электроэнергии за отчетный период</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CU_ElectricalEnergyType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>322:2-338:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CU_ElectricalEnergyType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CU_ElectricalEnergyTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Количество электроэнергии</remarks>
        [LxElementValue("ElectricalEnergyQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal ElectricalEnergyQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения</remarks>
        [LxElementValue("QualifierCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String QualifierCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUConsigmentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о перевозке товаров. Гр. 15, 15а, 17,17а, 18, 19, 21, 25, 26, 29  -ДТ/ Гр. 15, 17, 18, 19, 21, 25, 26, 29 , 53, 55- ТД</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUConsigmentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>339:2-385:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUConsigmentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUConsigmentTypeCt
    {
        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Признак контейнерных перевозок. Гр.19</remarks>
        [LxElementValue("ContainerIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? ContainerIndicator { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна отправления. Буквенный код страны в соответствии с классификатором стран мира. Гр 15, подраздел a</remarks>
        [LxElementValue("DispatchCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String DispatchCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны отправления в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь. Гр.15, подраздел b</remarks>
        [LxElementValue("RBDispatchCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBDispatchCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна отправления. Краткое название страны в соответствии с классификатором стран мира. Гр.15</remarks>
        [LxElementValue("DispatchCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String DispatchCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна назначения. Буквенный код страны в соответствии с классификатором стран мира / 00 (неизвестна). Гр 17, подраздел a</remarks>
        [LxElementValue("DestinationCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String DestinationCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна назначения. Краткое название страны в соответствии с классификатором стран мира / НЕИЗВЕСТНА. Гр 17</remarks>
        [LxElementValue("DestinationCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String DestinationCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны назначения в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь. Гр.17, подраздел b</remarks>
        [LxElementValue("RBDestinationCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBDestinationCountryCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган въезда или выезда. Гр.29</remarks>
        [LxElementCt("BorderCustomsOffice", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt> BorderCustomsOffices { get; } = new List<CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType CUCustomsPaymentCalculationType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Исчисление таможенных платежей</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUCustomsPaymentCalculationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>386:2-557:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUCustomsPaymentCalculationType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUCustomsPaymentCalculationTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида платежа по классификатору видов налогов, сборов и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "4")]
        public System.String PaymentModeCode { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сумма платежа</remarks>
        [LxElementValue("PaymentAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PaymentAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты суммы платежа</remarks>
        [LxElementValue("PaymentCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String PaymentCurrencyCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Основа начисления</remarks>
        [LxElementValue("TaxBase", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TaxBase { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты основы начисления (адвалорная ставка)</remarks>
        [LxElementValue("TaxBaseCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String TaxBaseCurrencyCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения основы начисления (специфическая ставка)</remarks>
        [LxElementValue("TaxBaseTNVEDQualifierCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String TaxBaseTNVEDQualifierCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Ставка / ставка рефинансирования</remarks>
        [LxElementValue("Rate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "12", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? Rate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Вид ставки (адвалорная -«%», признак сборов для РК - «S» , специфическая - «*»)</remarks>
        [LxElementValue("RateTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RateTypeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты ставки (специфическая ставка)</remarks>
        [LxElementValue("RateCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String RateCurrencyCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения ставки (специфическая ставка)</remarks>
        [LxElementValue("RateTNVEDQualifierCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RateTNVEDQualifierCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Весовой коэффициент единицы измерения (специфическая ставка)</remarks>
        [LxElementValue("WeightingFactor", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "9", FractionDigits = "3")]
        public LiquidTechnologies.XmlObjects.BigDecimal? WeightingFactor { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Знак операции сравнения (1 - меньше, 2 - больше)</remarks>
        [LxElementValue("ComparisonOperationsSign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? ComparisonOperationsSign { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Ставка</remarks>
        [LxElementValue("Rate2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "12", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? Rate2 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Вид ставки (адвалорная -«%», признак сборов для РК - «S», специфическая - «*»)</remarks>
        [LxElementValue("RateTypeCode2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RateTypeCode2 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты ставки (специфическая ставка)</remarks>
        [LxElementValue("RateCurrencyCode2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String RateCurrencyCode2 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения ставки (специфическая ставка)</remarks>
        [LxElementValue("RateTNVEDQualifierCode2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RateTNVEDQualifierCode2 { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Весовой коэффициент единицы измерения (специфическая ставка)</remarks>
        [LxElementValue("WeightingFactor2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "9", FractionDigits = "3")]
        public LiquidTechnologies.XmlObjects.BigDecimal? WeightingFactor2 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Знак операции</remarks>
        [LxElementValue("OperationsSign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String OperationsSign { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Ставка</remarks>
        [LxElementValue("Rate3", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "12", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? Rate3 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Вид ставки (адвалорная -«%», специфическая - «*»)</remarks>
        [LxElementValue("RateTypeCode3", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RateTypeCode3 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты ставки (специфическая ставка)</remarks>
        [LxElementValue("RateCurrencyCode3", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String RateCurrencyCode3 { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения ставки (специфическая ставка)</remarks>
        [LxElementValue("RateTNVEDQualifierCode3", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RateTNVEDQualifierCode3 { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Весовой коэффициент единицы измерения (специфическая ставка)</remarks>
        [LxElementValue("WeightingFactor3", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "9", FractionDigits = "3")]
        public LiquidTechnologies.XmlObjects.BigDecimal? WeightingFactor3 { get; set; }

        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Результат выполнения операции сравнения: 1 - истина; 0 - ложь</remarks>
        [LxElementValue("ComparisonResult", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? ComparisonResult { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата применения ставки таможенного платежа</remarks>
        [LxElementValue("RateUseDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? RateUseDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код в соответствии с классификатором особенностей уплаты таможенных и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String PaymentCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество дней</remarks>
        [LxElementValue("NumberDays", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "4")]
        public System.Numerics.BigInteger? NumberDays { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Число этапов</remarks>
        [LxElementValue("NumberStages", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? NumberStages { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Число полных и неполных календарных месяцев</remarks>
        [LxElementValue("NumberMonths", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? NumberMonths { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Тарифный коэффициент</remarks>
        [LxElementValue("TariffRate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "4", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TariffRate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер строки из гр.40</remarks>
        [LxElementValue("LineNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? LineNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер группы. Для РФ</remarks>
        [LxElementValue("NumberGroup", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String NumberGroup { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Номер товара в предшествующем документе</remarks>
        [LxElementValue("PrecedingDocumentGoodsNumeric", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? PrecedingDocumentGoodsNumeric { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUDelayPaymentsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Отсрочка платежей гр.48</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUDelayPaymentsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>558:2-579:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUDelayPaymentsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUDelayPaymentsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида таможенного платежа по классификатору видов налогов, сборов и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String PaymentModeCode { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Последний день срока отсрочки уплаты платежа</remarks>
        [LxElementValue("EndDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EndDate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.PaymentSheduleDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.PaymentSheduleDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об этапе рассрочки уплаты платежа</remarks>
        [LxElementCt("PaymentSheduleDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.PaymentSheduleDetailsTypeCt PaymentSheduleDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUDriverInformationType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Информация о водителях транспортных средств. Заполняется при транзите товаров автомобильным транспортом</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUDriverInformationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>597:2-617:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUDriverInformationType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUDriverInformationTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны регистрации водителя транспортного средства</remarks>
        [LxElementValue("RegCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String RegCountryCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt IdentityCard { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt();

    }

    /// <summary>A class representing the root XSD complexType CUESADCustomsRepresCertificateType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Документ, свидетельствующий о включении лица в Реестр таможенных представителей</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADCustomsRepresCertificateType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>618:2-633:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADCustomsRepresCertificateType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADCustomsRepresCertificateTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Тип документа:2 - свидетельство таможенного представителя (брокера); 3 - свидетельство таможенного представителя</remarks>
        [LxElementValue("DocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String DocumentModeCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUESADCustomsRepresentativeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Таможенный представитель</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADCustomsRepresentativeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>634:2-677:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADCustomsRepresentativeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADCustomsRepresentativeTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.FilledPersonAuthDocTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV4TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.BasePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SimplePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />
        /// </summary>
        /// <remarks>Договор таможенного представителя с декларантом</remarks>
        [LxElementCt("ContractRepresDecl", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt ContractRepresDecl { get; set; } = new CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" />
        /// </summary>
        /// <remarks>Документ, свидетельствующий о включении лица в Реестр таможенных представителей</remarks>
        [LxElementCt("CustomsRepresCertificate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt CustomsRepresCertificate { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
        [LxElementCt("RKOrganizationFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt RKOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
        [LxElementCt("RBOrganizationFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt RBOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
        [LxElementCt("RAOrganizationFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt RAOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
        [LxElementCt("KGOrganizationFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt KGOrganizationFeatures { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUESADGoodsItemType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о товаре</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADGoodsItemType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>678:2-833:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADGoodsItemType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADGoodsItemTypeCt : CustomsLiquidXml.XSD.CatESADCu.GoodsItemBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара по ТН ВЭД ЕАЭС. Гр.33 первый раздел</remarks>
        [LxElementValue("GoodsTNVEDCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{4}|[0-9]{6}|[0-9]{8}|[0-9]{10}")]
        public System.String GoodsTNVEDCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Особенность классификации кода: 1 - общий «О», 2 - товар списка. В остальных случаях не заполняется</remarks>
        [LxElementValue("GoodsClassificationCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String GoodsClassificationCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Дополнительный признак нетарифного регулирования («С»). Гр.33 второй раздел</remarks>
        [LxElementValue("AdditionalSign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String AdditionalSign { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак объекта интеллектуальной собственности («И»). Гр.33 второй раздел в ДТ</remarks>
        [LxElementValue("IntellectPropertySign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String IntellectPropertySign { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак отнесения товаров к товарам, подлежащим маркировке контрольными (идентификационными) знаками («М»). Гр.33 ДТ, второй подраздел</remarks>
        [LxElementValue("CIMSign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String CIMSign { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Буквенный код соблюдения запретов и ограничений в соответствии с классификатором. Для РК</remarks>
        [LxElementValue("RestrictionSign", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "5")]
        public List<System.String> RestrictionSigns { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала периода (ОПД)</remarks>
        [LxElementValue("BeginPeriodDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? BeginPeriodDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания периода (ОПД)</remarks>
        [LxElementValue("EndPeriodDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EndPeriodDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны происхождения в соответствии с классификатором стран мира / «EU» / 00 (неизвестна). Гр.34</remarks>
        [LxElementValue("OriginCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String OriginCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое название страны происхождения / экономического союза</remarks>
        [LxElementValue("OriginCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String OriginCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны происхождения в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь</remarks>
        [LxElementValue("RBOriginCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBOriginCountryCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt" />
        /// </summary>
        /// <remarks>Страна происхождения, определенная в соответствии с правилами определения происхождения товаров, применяемыми при предоставлении тарифных преференций</remarks>
        [LxElementCt("PrefOriginCountry", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt PrefOriginCountry { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код метода определения таможенной стоимости. В соответствии с классификатором методов определения таможенной стоимости. Гр. 43</remarks>
        [LxElementValue("CustomsCostCorrectMethod", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MaxLength = "1")]
        public System.String CustomsCostCorrectMethod { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара в соответствии с классификатором дополнительной таможенной информации</remarks>
        [LxElementValue("GoodsAddTNVEDCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4}")]
        public System.String GoodsAddTNVEDCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара, в отношении импорта которого введено автоматическое лицензирование (наблюдение)</remarks>
        [LxElementValue("LicenseGoodsKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "4")]
        public System.String LicenseGoodsKindCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала периода поставки. (элемент 7 гр. 31 ДТ)</remarks>
        [LxElementValue("DeliveryTime", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DeliveryTime { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания периода поставки. (элемент 7 гр. 31 ДТ)</remarks>
        [LxElementValue("DeliveryTimeEND", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DeliveryTimeEND { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер листа (первый подраздел гр.3)</remarks>
        [LxElementValue("AdditionalSheetCount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? AdditionalSheetCount { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товаров, фактически переданных покупателю в соответствии с условиями поставки (элемент 8 гр. 31 ДТ)</remarks>
        [LxElementCt("QuantityFact", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt QuantityFact { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Сведения о месторождении товара</remarks>
        [LxElementValue("OilField", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> OilFields { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара ТН ВЭД, действующий на дату заключения контрактов с недропользователем. Для РК</remarks>
        [LxElementValue("TNVEDContract", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{9}|[0-9]{10}")]
        public System.String TNVEDContract { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер объекта интеллектуальной собственности по реестру объектов интеллектуальной  собственности</remarks>
        [LxElementCt("IPObjectRegistryNum", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt> IPObjectRegistryNums { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt" />
        /// </summary>
        /// <remarks>Условия поставки товаров. Гр.31 пятый подраздел</remarks>
        [LxElementCt("CUESADDeliveryTerms", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt> CUESADDeliveryTerms { get; } = new List<CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADContractDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADContractDetailsTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные сведения по договору (контракту)</remarks>
        [LxElementCt("ForeignTradeContractDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADContractDetailsTypeCt> ForeignTradeContractDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADContractDetailsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt" />
        /// </summary>
        /// <remarks>Описание и характеристика товаров / Описание группы товаров одного наименования с отличающимися от других групп характеристиками</remarks>
        [LxElementCt("GoodsGroupDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt> GoodsGroupDescriptions { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPreferenciiTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPreferenciiTypeCt" />
        /// </summary>
        /// <remarks>Преференции в соответствии с классификатором льгот по уплате таможенных платежей. Гр.36</remarks>
        [LxElementCt("Preferencii", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUPreferenciiTypeCt Preferencii { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CIMIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об идентификационных номерах (идентификаторах) нанесенных контрольных (идентификационных) знаков (элемент 10 гр. 31 ДТ))</remarks>
        [LxElementCt("CIMIdDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CIMIdDetailsTypeCt CIMIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DTIdentificationMeansDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DTIdentificationMeansDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о средствах идентификации ( элемент  13 гр 31 ДТ)</remarks>
        [LxElementCt("DTIdentificationMeansDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DTIdentificationMeansDetailsTypeCt DTIdentificationMeansDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsSTZTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsSTZTypeCt" />
        /// </summary>
        /// <remarks>Сведения о товарах, помещенных под таможенную процедуру СТЗ или свободного склада. гр 31 п 11. Для РК и РФ</remarks>
        [LxElementCt("GoodsSTZ", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.GoodsSTZTypeCt> GoodsSTZs { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.GoodsSTZTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType CUESADGoodsShipmentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о товарной партии</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADGoodsShipmentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>834:2-895:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADGoodsShipmentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADGoodsShipmentTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна происхождения товара. Краткое название страны в соответствии с классификатором стран мира / РАЗНЫЕ/ НЕИЗВЕСТНА/ ЕВРОСОЮЗ</remarks>
        [LxElementValue("OriginCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String OriginCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна происхождения. Буквенный код страны в соответствии с классификатором стран мира.</remarks>
        [LxElementValue("OriginCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String OriginCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны происхождения в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь</remarks>
        [LxElementValue("RBOriginCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBOriginCountryCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общее количество представленных спецификаций</remarks>
        [LxElementValue("SpecificationNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? SpecificationNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общее количество листов представленных спецификаций</remarks>
        [LxElementValue("SpecificationListNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? SpecificationListNumber { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Всего наименований товаров в декларации на товары</remarks>
        [LxElementValue("TotalGoodsNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? TotalGoodsNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общее количество грузовых мест</remarks>
        [LxElementValue("TotalPackageNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalPackageNumber { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество листов</remarks>
        [LxElementValue("TotalSheetNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? TotalSheetNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сведения о стоимости/общая таможенная стоимость декларируемых товаров</remarks>
        [LxElementValue("TotalCustCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalCustCost { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общая таможенная стоимость товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде</remarks>
        [LxElementValue("TotalCustomsValueAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalCustomsValueAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код валюты таможенной стоимости в соответствии с классификатором валют</remarks>
        [LxElementValue("CustCostCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String CustCostCurrencyCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUESADMainContractTermsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об условиях сделки. Гр. 11, 20, 22, 23, 24</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADMainContractTermsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>896:2-931:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADMainContractTermsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADMainContractTermsTypeCt : CustomsLiquidXml.XSD.CatESADCu.ContractCostTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код торгующей страны в соответствии с классификатором стран мира. Гр.11, 1-й подраздел ДТ</remarks>
        [LxElementValue("TradeCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String TradeCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь. Гр.11, 2-й подраздел ДТ</remarks>
        [LxElementValue("RBCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код особенности сделки (договора). В соответствии с классификатором особенности внешнеэкономической сделки, используемым в государствах - членах Евразийского экономического союза. Гр. 24 ДТ</remarks>
        [LxElementValue("DealFeatureCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String DealFeatureCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код характера сделки с декларируемыми товарами в соответствии с классификатором характера сделки, используемым в государствах - членах Евразийского экономического союза. Гр.24 ДТ</remarks>
        [LxElementValue("DealNatureCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String DealNatureCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt" />
        /// </summary>
        /// <remarks>Условия поставки товаров. Гр. 20 ДТ</remarks>
        [LxElementCt("CUESADDeliveryTerms", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.DeliveryTermsTypeCt CUESADDeliveryTerms { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUESADPresentedDocumentsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Представленные документы. Гр. 44</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUESADPresentedDocumentsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>932:2-1032:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUESADPresentedDocumentsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUESADPresentedDocumentsTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенного органа, зарегистрировавшего документ</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("PresentedDocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "5")]
        public System.String PresentedDocumentModeCode { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала действия документа</remarks>
        [LxElementValue("DocumentBeginActionsDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocumentBeginActionsDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания действия документа</remarks>
        [LxElementValue("DocumentEndActionsDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocumentEndActionsDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Код срока временного ввоза. 1- если срок временного ввоз/вывоза менее 1 года, 2- если срок временного ввоз/вывоза более 1 года</remarks>
        [LxElementValue("TemporaryImportCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TemporaryImportCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Заявляемый срок временного ввоза/вывоза./Срок хранения товаров/Запрашиваемый срок переработки</remarks>
        [LxElementValue("TemporaryStorageImportDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? TemporaryStorageImportDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида таможенного платежа по классификатору видов налогов, сборов и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("CustomsPaymentModeCodeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "4")]
        public System.String CustomsPaymentModeCodeType { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>11 - ОПЕРЕЖАЮЩАЯ ПОСТАВКА. Заполняется если продукты переработки ввозятся раньше, чем осуществлен вывоз товаров на переработку вне таможенной территории. В остальных случаях не заполняется</remarks>
        [LxElementValue("SupplyStatus", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String SupplyStatus { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны в соответствии с классификатором стран мира, в которой выдан сертификат</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Общее количество документов (ПС, контрактов) для РФ</remarks>
        [LxElementValue("TotalDocuments", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? TotalDocuments { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны классификации документов, подтверждающих наличие льгот или особенностей по уплате таможенных платежей. Для РБ</remarks>
        [LxElementValue("PreferenciiCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String PreferenciiCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор документа, по национальному классификатору документов, необходимых для декларирования товаров в соответствии с классификатором кодов дополнительной информации о документах. Для РБ</remarks>
        [LxElementValue("PreferenciiDocID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "6")]
        public System.String PreferenciiDocID { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsCostInfoTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsCostInfoTypeCt" />
        /// </summary>
        /// <remarks>Сведения о стоимости операций по переработке товаров, помещенных под таможенную процедуру переработки товаров вне таможенной территории</remarks>
        [LxElementCt("ProcessingGoodsCostInfo", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsCostInfoTypeCt ProcessingGoodsCostInfo { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор записи (для РФ)</remarks>
        [LxElementValue("RecordID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String RecordID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор государственного или межгосударственного органа (организации), выдавшего или утвердившего документ</remarks>
        [LxElementValue("ExecutiveBodyID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String ExecutiveBodyID { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Полное наименование  органа государственной власти государства-члена либо уполномоченной им организации, выдавшей документ</remarks>
        [LxElementValue("ExecutiveName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "150")]
        public List<System.String> ExecutiveNames { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.LicenseGoodsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.LicenseGoodsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о декларируемом товаре по лицензии</remarks>
        [LxElementCt("LicenseGoods", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.LicenseGoodsTypeCt LicenseGoods { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные технологические идентификаторы представленного документа. Гр 44 (для РФ)</remarks>
        [LxElementCt("RFG44PresentedDocId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt RFG44PresentedDocId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUGoodsLocationPlaceType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о местонахождении товаров</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUGoodsLocationPlaceType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1033:2-1044:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUGoodsLocationPlaceType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUGoodsLocationPlaceTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер (регистрационный номер) зоны таможенного контроля</remarks>
        [LxElementValue("NumberCustomsZone", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String NumberCustomsZone { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType CUGuaranteeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Гарантия</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUGuaranteeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1045:2-1076:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUGuaranteeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUGuaranteeTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код способов обеспечения уплаты в соответствии с классификатором способов обеспечения уплаты таможенных и иных платежей</remarks>
        [LxElementValue("PaymentWayCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String PaymentWayCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Сумма (размер) обеспечения</remarks>
        [LxElementValue("Amount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal Amount { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, подтверждающем обеспечение исполнения обязанности по уплате таможенных и иных платежей</remarks>
        [LxElementCt("GuaranteeDocDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt GuaranteeDocDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Учетный номер плательщика (УНП)</remarks>
        [LxElementValue("UNP", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String UNP { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Банковский идентификационный код или небанковский идентификационный код кредитно-финансовой организации</remarks>
        [LxElementValue("BIC", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String BIC { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUIdentityCardType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе, удостоверяющем личность физического лица</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUIdentityCardType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1077:2-1138:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUIdentityCardType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUIdentityCardTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа, удостоверяющего личность, в соответствии с классификатором видов документов, удостоверяющих личность</remarks>
        [LxElementValue("IdentityCardCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "(\\d{2})|([A-Z]{2}\\d{5})")]
        public System.String IdentityCardCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String IdentityCardName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Полное наименование документа, удостоверяющего личность</remarks>
        [LxElementValue("FullIdentityCardName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String FullIdentityCardName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Серия документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardSeries", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "11")]
        public System.String IdentityCardSeries { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String IdentityCardNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата выдачи документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? IdentityCardDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организации, выдавшей документ</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String OrganizationName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код подразделения органа, выдавшего документ, удостоверяющий личность</remarks>
        [LxElementValue("IssuerCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String IssuerCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Строка, идентифицирующая орган государственной власти государства-члена либо уполномоченную им организацию, выдавшую документ</remarks>
        [LxElementValue("AuthorityId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String AuthorityId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUMarkExcisableGoodsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о маркированных подакцизных товарах</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUMarkExcisableGoodsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1139:2-1160:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUMarkExcisableGoodsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUMarkExcisableGoodsTypeCt
    {
        /// <summary>A collection of <see cref="System.Numerics.BigInteger" /></summary>
        /// <remarks>Серия марок</remarks>
        [LxElementValue("Series", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinInclusive = "1", TotalDigits = "5")]
        public List<System.Numerics.BigInteger> Seriess { get; } = new List<System.Numerics.BigInteger>();

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Номер марки</remarks>
        [LxElementValue("Number", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger? Number { get; set; }

        /// <summary>A collection of <see cref="LiquidTechnologies.XmlObjects.BigDecimal" /></summary>
        /// <remarks>Количество акцизных марок</remarks>
        [LxElementValue("QuantityMark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public List<LiquidTechnologies.XmlObjects.BigDecimal> QuantityMarks { get; } = new List<LiquidTechnologies.XmlObjects.BigDecimal>();

    }

    /// <summary>A class representing the root XSD complexType CUPrecedingDocumentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Предшествующие документы</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUPrecedingDocumentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1161:2-1196:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUPrecedingDocumentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUPrecedingDocumentTypeCt : CustomsLiquidXml.XSD.CatESADCu.PrecedingDocumentTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Масса нетто товара, вошедшего в состав декларируемого товара. для РБ/Масса нетто товара, использованного при изготовлении декларируемого товара</remarks>
        [LxElementValue("NetWeightQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeightQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны таможенного органа</remarks>
        [LxElementValue("CustomsCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CustomsCountryCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Таможенная стоимость товара, указанная в гр 45 предшествующей ДТ</remarks>
        [LxElementValue("CustomsCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CustomsCost { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Масса нетто товара, указанная в гр 38 предшествующей ДТ</remarks>
        [LxElementValue("NetWeight", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeight { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара предшествующего документа, использованного при изготовлении или вошедшего в состав декларируемого товара</remarks>
        [LxElementCt("SupplementaryGoodsQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> SupplementaryGoodsQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType CUPreferenciiType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Преференции в соответствии с классификатором льгот по уплате таможенных платежей. Гр.36</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUPreferenciiType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1197:2-1223:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUPreferenciiType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUPreferenciiTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Таможенные сборы</remarks>
        [LxElementValue("CustomsTax", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String CustomsTax { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Таможенная пошлина</remarks>
        [LxElementValue("CustomsDuty", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String CustomsDuty { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Акцизы</remarks>
        [LxElementValue("Excise", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String Excise { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Налог на добавленную стоимость</remarks>
        [LxElementValue("Rate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String Rate { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType CUPresentedDocumentsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>ESAD.Представленные документы</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUPresentedDocumentsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1224:2-1249:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUPresentedDocumentsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUPresentedDocumentsTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер листа книжки МДП</remarks>
        [LxElementValue("TIRPageNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "2")]
        public System.Numerics.BigInteger? TIRPageNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер держателя книжки МДП</remarks>
        [LxElementValue("TIRHolderID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "18")]
        public System.String TIRHolderID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер таможенного документа, с которым он был первоначально представлен</remarks>
        [LxElementValue("RegNumberDocument", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String RegNumberDocument { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUTransportType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о местонахождении товаров - транспортное средство</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUTransportType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1250:2-1266:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUTransportType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUTransportTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида транспортного средства в соответствии с классификатором видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransporKind", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String TransporKind { get; set; } = "";

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Номер транспортного средства</remarks>
        [LxElementValue("TransporIdentifier", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "40")]
        public List<System.String> TransporIdentifiers { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType CUWarehousePlaceType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе свидетельствующем о включении в реестры уполномоченных экономических операторов либо реестры владельцев складов хранения собственных товаров, владельцев складов временного хранения, владельцев таможенных складов либо свободных складов, разрешение на временное хранение на складе получателя</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:CUWarehousePlaceType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1267:2-1274:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUWarehousePlaceType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class CUWarehousePlaceTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType DeliveryTermsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Условия поставки товаров</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:DeliveryTermsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1275:2-1296:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeliveryTermsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class DeliveryTermsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование географического пункта или места передачи товаров</remarks>
        [LxElementValue("DeliveryPlace", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DeliveryPlace { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код условий поставки в соответствии с классификатором условий поставки</remarks>
        [LxElementValue("DeliveryTermsStringCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\D{3}")]
        public System.String DeliveryTermsStringCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида поставки товаров в соответствии с классификатором видов поставок товаров, подлежащих учету при осуществлении экспортных операций, применяемым в Республике Беларусь</remarks>
        [LxElementValue("DeliveryTermsRBCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String DeliveryTermsRBCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DimensionType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Линейные размеры объекта (длина, ширина и высота)</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:DimensionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1297:2-1318:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DimensionType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class DimensionTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Линейный размер объекта в продольном направлении</remarks>
        [LxElementCt("LengthMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt LengthMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Линейный размер объекта в поперечном направлении</remarks>
        [LxElementCt("WidthMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt WidthMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt" />
        /// </summary>
        /// <remarks>Линейный размер объекта в вертикальном направлении</remarks>
        [LxElementCt("HeightMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedPhysicalMeasureTypeCt HeightMeasure { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocBaseType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о базовых реквизитах документа</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:DocBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1319:2-1349:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocBaseType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class DocBaseTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocStartDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocStartDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DTIdentificationMeansDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о средствах идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:DTIdentificationMeansDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1350:2-1366:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DTIdentificationMeansDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class DTIdentificationMeansDetailsTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Общее количество кодов идентификации, содержащихся в средствах идентификации, нанесенных на каждую единицу товара, или на товарный ярлык или потребительскую упаковку (а в случае ее отсутствия – на первичную упаковку)</remarks>
        [LxElementValue("CIMQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "10")]
        public System.Numerics.BigInteger CIMQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о средстве идентификации</remarks>
        [LxElementCt("IdentificationMeansDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDetailsTypeCt> IdentificationMeansDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType DTMDocDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер декларации на транспортное средство</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:DTMDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1367:2-1382:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DTMDocDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class DTMDocDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида транспортного средства по классификатору видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransportModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String TransportModeCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType EECCustomsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Таможенный орган ЕАЭС</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:EECCustomsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1383:2-1398:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECCustomsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class EECCustomsTypeCt : CustomsLiquidXml.XSD.CatRu.CustomsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType ESADCommonOfficialMarkType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>ДТ и ТД. Внутренний формат. Служебные отметки по ДТ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADCommonOfficialMarkType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1399:2-1520:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADCommonOfficialMarkType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADCommonOfficialMarkTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Обозначение графы (подраздела графы) (A,C,D,E1,E2,28)  Графе D/J соответствует 'D'. Графам E, E/J соответствуют:'E1' - верхний (первый) подраздел графы E(E/J); 'E2' - нижний (второй) подраздел графы E(E/J)</remarks>
        [LxElementValue("GRNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "2")]
        public System.String GRNumber { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Идентификатор проставленной технологической отметки - 1 (номер этапа)</remarks>
        [LxElementValue("StageMarkIdentifier", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String StageMarkIdentifier { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Идентификатор проставленной технологической отметки  -  2 (тип примечания)</remarks>
        [LxElementValue("NoteMarkIdentifier", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String NoteMarkIdentifier { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа информации (SKRECC)</remarks>
        [LxElementValue("InformationTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String InformationTypeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Служебная запись / номер документа</remarks>
        [LxElementValue("MarkDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String MarkDescription { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата проставления отметки/ Дата принятия решения о продлении срока проверки</remarks>
        [LxElementValue("DateInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DateInf { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время</remarks>
        [LxElementValue("TimeInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? TimeInf { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сумма денежных средств /Суммарный объем отделений транспортных средств / Фактурная стоимость</remarks>
        [LxElementValue("Amount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? Amount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида платежа (пени, штрафы, в случае полной уплаты таможенных пошлин, налогов при помещении товаров под таможенный режим временного ввоза)</remarks>
        [LxElementValue("PaymentTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String PaymentTypeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Процент за предоставление отсрочки / рассрочки (заполняется для 91, 93 видов там. платежей)</remarks>
        [LxElementValue("PostponementProcent", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MaxInclusive = "100", MinInclusive = "0", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PostponementProcent { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты денежных средств / Код единицы измерения / Буквенный код страны Примечание: код страны заполняется для кода типа информации "34"/ Буквенный код валюты (при указании фактурной стоимости)</remarks>
        [LxElementValue("Code", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String Code { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование валюты денежных средств / Условное обозначение единицы измерения</remarks>
        [LxElementValue("CurrencyName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "70")]
        public System.String CurrencyName { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>ФИО инспектора, заверившего запись</remarks>
        [LxElementValue("PersonName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonName { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер ЛНП инспектора, заверившего запись</remarks>
        [LxElementValue("LNP", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String LNP { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата завершения разделения товарной партии на отдельные товары</remarks>
        [LxElementValue("GoodsDevisionDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? GoodsDevisionDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время</remarks>
        [LxElementValue("GoodsDevisionTime", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? GoodsDevisionTime { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Срок</remarks>
        [LxElementValue("Deadline", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? Deadline { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенного органа</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата совершения отдельных таможенных операций</remarks>
        [LxElementValue("CustomsActionDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? CustomsActionDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак документа. Заполняется при указании номера: - акта таможенного досмотра (осмотра) - 'Д', 'О'; - если ДТ является последней полной таможенной декларацией ('Z'); -при проставлении отметки в нижнем подразделе графы E(E/J) под номером 12 (E2 2 12)  ("0"-сведения совпадают; "1"-сведения не совпадают)</remarks>
        [LxElementValue("DocumentIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String DocumentIndicator { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Срок продления / общий в месяцах</remarks>
        [LxElementValue("DeadlineMonth", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "2")]
        public System.Numerics.BigInteger? DeadlineMonth { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.FilledPersonAuthDocTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV4TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.BasePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SimplePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />
        /// </summary>
        /// <remarks>Информация о документе (номер, дата)</remarks>
        [LxElementCt("DocumentInfo", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt DocumentInfo { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUOrganizationTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBackAddrTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationWBankTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SubjectBaseDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsignorTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsigneeTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.OrganizationTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectBaseDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterOrganizationDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsBankTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DeclarantDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUFinancialAdjustingResponsiblePersonTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUCarrierTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации (лице)</remarks>
        [LxElementCt("CommonMarkOrganization", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt CommonMarkOrganization { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADConsigmentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о перевозке товаров. Гр. 15, 15а, 17,17а, 18, 19, 21, 25, 26, 29  -ДТ/ Гр. 15, 17, 18, 19, 21, 25, 26, 29 , 53, 55- ТД</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADConsigmentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1521:2-1572:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADConsigmentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADConsigmentTypeCt
    {
        /// <summary>A <see cref="System.Boolean" />, Required</summary>
        /// <remarks>Признак контейнерных перевозок. Гр.19</remarks>
        [LxElementValue("ContainerIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 1, MaxOccurs = 1)]
        public System.Boolean ContainerIndicator { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна отправления. Буквенный код по  классификатору стран мира .гр 15, подраздел a</remarks>
        [LxElementValue("DispatchCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String DispatchCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны отправления в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь. Гр.15,  подраздел b</remarks>
        [LxElementValue("RBDispatchCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBDispatchCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна отправления. Краткое наименование. Гр.15</remarks>
        [LxElementValue("DispatchCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String DispatchCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна назначения. Буквенный код по классификатору стран мира / 00 (неизвестна). Гр 17, подраздел a</remarks>
        [LxElementValue("DestinationCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String DestinationCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна назначения. Гр.17 Наименование / НЕИЗВЕСТНА</remarks>
        [LxElementValue("DestinationCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String DestinationCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код административно-территориального деления страны назначения в соответствии с классификатором административно-территориального деления стран, применяемым в Республике Беларусь. Гр.17,  подраздел b</remarks>
        [LxElementValue("RBDestinationCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RBDestinationCountryCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган назначения при транзите.гр.53 ТД.</remarks>
        [LxElementCt("DeliveryCustomsOffice", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt DeliveryCustomsOffice { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган въезда/выезда. Гр.29</remarks>
        [LxElementCt("BorderCustomsOffice", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt> BorderCustomsOffices { get; } = new List<CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADContainerType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о контейнерах</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADContainerType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1573:2-1594:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADContainerType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADContainerTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество контейнеров одного вида</remarks>
        [LxElementValue("ContainerQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8")]
        public System.Numerics.BigInteger? ContainerQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Тип контейнера в соответствии с классификатором видов груза, упаковки и упаковочных материалов</remarks>
        [LxElementValue("ContainerKind", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String ContainerKind { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ContainerNumberTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ContainerNumberTypeCt" />
        /// </summary>
        /// <remarks>Номер контейнера</remarks>
        [LxElementCt("ContainerNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ContainerNumberTypeCt> ContainerNumbers { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ContainerNumberTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADContractDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Дополнительные сведения по внешнеторговым контрактам</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADContractDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1595:2-1641:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADContractDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADContractDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.SubjectBaseDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SubjectBaseDetailsTypeCt" />
        /// </summary>
        /// <remarks>Получатель/отправитель товара по договору (контракту)</remarks>
        [LxElementCt("ForeignTradeConsignee", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.SubjectBaseDetailsTypeCt ForeignTradeConsignee { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.SubjectBaseDetailsTypeCt();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Уникальный номер договора (контракта), присвоенный уполномоченным банком при постановке договора (контракта) на учет</remarks>
        [LxElementValue("DealPassportNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DealPassportNumber { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />
        /// </summary>
        /// <remarks>Сведения о реквизитах договора (контракта)</remarks>
        [LxElementCt("ForeignMainContractDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt ForeignMainContractDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />
        /// </summary>
        /// <remarks>Сведения о реквизитах дополнения к договору (контракту)</remarks>
        [LxElementCt("ForeignAddContractDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt> ForeignAddContractDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DeliveryTermsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DeliveryTermsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об условиях поставки</remarks>
        [LxElementCt("DeliveryTerms", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DeliveryTermsTypeCt DeliveryTerms { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.DeliveryTermsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о стране происхождения</remarks>
        [LxElementCt("OriginCountryDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CountryDetailsTypeCt OriginCountryDetails { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Условная таможенная стоимость</remarks>
        [LxElementValue("CustomsCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CustomsCost { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара с указанием единиц измерения</remarks>
        [LxElementCt("GoodsQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> GoodsQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADContractListType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Дополнительные сведения по внешнеторговым контрактам. Для РФ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADContractListType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1642:2-1678:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADContractListType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADContractListTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер паспорта сделки</remarks>
        [LxElementValue("DealPassportNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DealPassportNumber { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер внешнеторгового контракта</remarks>
        [LxElementValue("ContractNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String ContractNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата внешнеторгового контракта</remarks>
        [LxElementValue("ContractDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ContractDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование банка, оформившего паспорт сделки</remarks>
        [LxElementValue("BankName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String BankName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyInformationsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyInformationsTypeCt" />
        /// </summary>
        /// <remarks>Описание поставки товаров.</remarks>
        [LxElementCt("SupplyInformations", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.SupplyInformationsTypeCt> SupplyInformations { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.SupplyInformationsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.FilledPersonAuthDocTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV4TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.BasePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SimplePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />
        /// </summary>
        /// <remarks>Дополнения и приложения к основному контракту.</remarks>
        [LxElementCt("AdditionalContract", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt> AdditionalContracts { get; } = new List<CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADCurrencyQuotaType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об остатке квоты в денежном выражении. Заполняется в случае, если квота установлена в денежном выражении</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADCurrencyQuotaType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1679:2-1700:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADCurrencyQuotaType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADCurrencyQuotaTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Остаток квоты в валюте</remarks>
        [LxElementValue("QuotaCurrencyQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal QuotaCurrencyQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Цифровой код валюты квоты в соответствии с классификатором кодов валют</remarks>
        [LxElementValue("QuotaCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String QuotaCurrencyCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование валюты квоты</remarks>
        [LxElementValue("QuotaCurrencyName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "70")]
        public System.String QuotaCurrencyName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADCustomsProcedureType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Процедура</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADCustomsProcedureType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1701:2-1722:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADCustomsProcedureType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADCustomsProcedureTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код заявляемой таможенной процедуры в соответствии с классификатором видов таможенных процедур / «00» - для припасов</remarks>
        [LxElementValue("MainCustomsModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String MainCustomsModeCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код предшествующей таможенной процедуры в соответствии с классификатором видов таможенных процедур / «00» - для припасов</remarks>
        [LxElementValue("PrecedingCustomsModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String PrecedingCustomsModeCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Особенность перемещения товаров в соответствии с классификатором особенностей перемещения товаров</remarks>
        [LxElementValue("GoodsTransferFeature", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String GoodsTransferFeature { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType ESADDecisionType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>ДТ и ТД. Принятое решение</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADDecisionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1723:2-1754:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADDecisionType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADDecisionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код решения в соответствии с классификатором решений,  принимаемых таможенными органами (**) - различно по товарам (заполняется при указании решения по декларации)</remarks>
        [LxElementValue("DecisionCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String DecisionCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата</remarks>
        [LxElementValue("DateInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DateInf { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время</remarks>
        [LxElementValue("TimeInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? TimeInf { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ЛНП</remarks>
        [LxElementValue("LNP", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String LNP { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Обоснование</remarks>
        [LxElementValue("Foundation", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String Foundation { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADExciseListType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Перечень номеров акцизных или специальных марок</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADExciseListType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1755:2-1766:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADExciseListType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADExciseListTypeCt
    {
        /// <summary>A collection of <see cref="LiquidTechnologies.XmlObjects.BigDecimal" /></summary>
        /// <remarks>Номер (идентификатор) акцизных или специальных марок</remarks>
        [LxElementValue("ExciseNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinInclusive = "1", TotalDigits = "8", FractionDigits = "0")]
        public List<LiquidTechnologies.XmlObjects.BigDecimal> ExciseNumbers { get; } = new List<LiquidTechnologies.XmlObjects.BigDecimal>();

    }

    /// <summary>A class representing the root XSD complexType ESADExciseRangeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Диапазон номеров акцизных марок</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADExciseRangeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1767:2-1783:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADExciseRangeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADExciseRangeTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Первый номер (идентификатор) диапазона номеров акцизных марок</remarks>
        [LxElementValue("ExciseFirstNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "8", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal ExciseFirstNumber { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Последний номер (идентификатор) диапазона номеров акцизных марок</remarks>
        [LxElementValue("ExciseLastNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "8", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal ExciseLastNumber { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADExciseType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об акцизных марках</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADExciseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1784:2-1810:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADExciseType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADExciseTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Количество акцизных или специальных марок</remarks>
        [LxElementValue("ExciseQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8")]
        public System.Numerics.BigInteger ExciseQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер серии акцизных или специальных марок</remarks>
        [LxElementValue("ExciseSerieses", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String ExciseSerieses { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseListTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseListTypeCt" />
        /// </summary>
        /// <remarks>Перечень номеров (идентификаторов) акцизных или специальных марок</remarks>
        [LxElementCt("ExciseList", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADExciseListTypeCt ExciseList { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseRangeTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseRangeTypeCt" />
        /// </summary>
        /// <remarks>Диапазон номеров акцизных или специальных марок</remarks>
        [LxElementCt("ExciseRange", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADExciseRangeTypeCt> ExciseRanges { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADExciseRangeTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADFilledPersonType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о лице, заполнившем декларацию</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADFilledPersonType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1811:2-1841:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADFilledPersonType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADFilledPersonTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер квалификационного аттестата специалиста по таможенному оформлению. Для РБ</remarks>
        [LxElementValue("QualificationCertificate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "6")]
        public System.String QualificationCertificate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.FilledPersonAuthDocTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, удостоверяющем полномочия, о доверенности на совершение действий</remarks>
        [LxElementCt("AuthoritesDocument", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt AuthoritesDocument { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUIdentityCardTypeCt IdentityCard { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактная информация</remarks>
        [LxElementCt("Contact", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt Contact { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADGoodsOfficialMarkType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>ДТ и ТД. Внутренний формат. Служебные отметки по товару</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADGoodsOfficialMarkType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1842:2-1913:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADGoodsOfficialMarkType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADGoodsOfficialMarkTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Идентификатор проставленной технологической отметки - 1 (номер этапа)</remarks>
        [LxElementValue("StageMarkIdentifier", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String StageMarkIdentifier { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Идентификатор проставленной технологической отметки  -  2 (тип примечания)</remarks>
        [LxElementValue("NoteMarkIdentifier", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String NoteMarkIdentifier { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа информации  (SKRECC)</remarks>
        [LxElementValue("InformationTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String InformationTypeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Служебная запись / номер документа</remarks>
        [LxElementValue("MarkDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String MarkDescription { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата / Дата принятия решения о направлении требования / приостановлении выпуска товаров</remarks>
        [LxElementValue("DateInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DateInf { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время</remarks>
        [LxElementValue("TimeInf", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? TimeInf { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>ФИО инспектора, заверившего запись</remarks>
        [LxElementValue("PersonName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String PersonName { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер ЛНП инспектора, заверившего запись</remarks>
        [LxElementValue("LNP", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String LNP { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата выполнения требований (предоставления документов) Декларантом / Дата, по которой приостановлен выпуск товаров</remarks>
        [LxElementValue("ReqCompletionDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ReqCompletionDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время</remarks>
        [LxElementValue("ReqCompletionTime", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ReqCompletionTime { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак документа / служебной записи. Заполняется при проставлении отметки в графе C под номером 12 (C 2 12)   ("0"-сведения о товаре совпадают; "1"-сведения о товаре не совпадают)</remarks>
        [LxElementValue("DocumentIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String DocumentIndicator { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Срок</remarks>
        [LxElementValue("Deadline", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? Deadline { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Срок продления / общий в месяцах</remarks>
        [LxElementValue("DeadlineMonth", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "2")]
        public System.Numerics.BigInteger? DeadlineMonth { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADGoodsPackagingType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о грузовых местах, поддонах и упаковке товаров</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADGoodsPackagingType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1914:2-1940:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADGoodsPackagingType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADGoodsPackagingTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общее количество грузовых мест, занятых товаром</remarks>
        [LxElementValue("PakageQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PakageQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код наличия упаковки товара: 0 - Без упаковки; 1 - С упаковкой; 2 - Без упаковки в оборудованных емкостях транспортного средства</remarks>
        [LxElementValue("PakageTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String PakageTypeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Количество грузовых мест, частично занятых товаром</remarks>
        [LxElementValue("PakagePartQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PakagePartQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.PackagePalleteInformationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.PackagePalleteInformationTypeCt" />
        /// </summary>
        /// <remarks>Сведения о грузе, таре, упаковке, поддоне</remarks>
        [LxElementCt("PackagePalleteInformation", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.PackagePalleteInformationTypeCt> PackagePalleteInformations { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.PackagePalleteInformationTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADGoodsQuotaType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Квота</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADGoodsQuotaType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1941:2-1962:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADGoodsQuotaType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADGoodsQuotaTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADProductQuantityQuotaTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADProductQuantityQuotaTypeCt" />
        /// </summary>
        /// <remarks>Сведения об остатке квоты, выраженные в количестве продукта. Заполняется в случае, если квота указывается в единицах измерения</remarks>
        [LxElementCt("ESADProductQuantityQuota", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADProductQuantityQuotaTypeCt> ESADProductQuantityQuotas { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADProductQuantityQuotaTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADCurrencyQuotaTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADCurrencyQuotaTypeCt" />
        /// </summary>
        /// <remarks>Сведения об остатке квоты в стоимостном выражении. Заполняется в случае, если квота установлена в стоимостном выражении</remarks>
        [LxElementCt("ESADCurrencyQuota", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADCurrencyQuotaTypeCt ESADCurrencyQuota { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество декларируемого товара в единице измерения, необходимое для списания квоты. Для РК</remarks>
        [LxElementCt("SupplementaryGoodsQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt SupplementaryGoodsQuantity { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUCustomsPaymentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об уплачиваемых платежах. Гр. B</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADout_CUCustomsPaymentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1963:2-1989:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUCustomsPaymentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADout_CUCustomsPaymentTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида таможенного платежа по классификатору видов налогов, сборов и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String PaymentModeCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Сумма платежа</remarks>
        [LxElementValue("PaymentAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal PaymentAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты суммы платежа</remarks>
        [LxElementValue("PaymentCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String PaymentCurrencyCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Курс валюты платежа</remarks>
        [LxElementValue("CurrencyRate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "11", FractionDigits = "4")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CurrencyRate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADProductQuantityQuotaType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об остатке квоты, выраженные в количестве продукта. Заполняется в случае, если квота указывается в единицах измерения</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADProductQuantityQuotaType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1990:2-2011:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADProductQuantityQuotaType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADProductQuantityQuotaTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Остаток квоты в единице измерения</remarks>
        [LxElementValue("QuotaQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal QuotaQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код единицы измерения квоты в соответствии с классификатором единиц измерения</remarks>
        [LxElementValue("QuotaMeasureUnitQualifierCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String QuotaMeasureUnitQualifierCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование единицы измерения квоты</remarks>
        [LxElementValue("QuotaMeasurementName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String QuotaMeasurementName { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType ESADReloadContainerType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о новых контейнерах</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADReloadContainerType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2012:2-2023:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADReloadContainerType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADReloadContainerTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Номер нового контейнера</remarks>
        [LxElementValue("ContainerNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "17")]
        public List<System.String> ContainerNumbers { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType ESADReloadingInfoType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Информация о перегрузке товаров. Гр. 55 ТД</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ESADReloadingInfoType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2024:2-2080:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADReloadingInfoType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ESADReloadingInfoTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны перегрузки товара</remarks>
        [LxElementValue("ReloadCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String ReloadCountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование страны перегрузки товара</remarks>
        [LxElementValue("ReloadCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String ReloadCountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Название пункта осуществления перегрузки товара</remarks>
        [LxElementValue("PlaceName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String PlaceName { get; set; }

        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Признак контейнерных перевозок</remarks>
        [LxElementValue("ContainerIndicator", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? ContainerIndicator { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида транспортного средства по классификатору видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransportModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String TransportModeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны принадлежности (регистрации) транспортных средств по классификатору стран мира. 99-разные, 00-неизвестна</remarks>
        [LxElementValue("TransportNationalityCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String TransportNationalityCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество транспортных средств</remarks>
        [LxElementValue("TransportMeansQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger? TransportMeansQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Новое транспортное средство</remarks>
        [LxElementCt("ReloadingTransportMeans", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt> ReloadingTransportMeans { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.EECCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.EECCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган перегрузки товаров</remarks>
        [LxElementCt("ReloadingCustomsOffice", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.EECCustomsTypeCt ReloadingCustomsOffice { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADReloadContainerTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADReloadContainerTypeCt" />
        /// </summary>
        /// <remarks>Сведения о новых контейнерах</remarks>
        [LxElementCt("ReloadContainer", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADReloadContainerTypeCt ReloadContainer { get; set; }

    }

    /// <summary>A class representing the root XSD complexType FilledPersonAuthDocType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Документ,  удостоверяющий полномочия декларанта</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:FilledPersonAuthDocType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2081:2-2106:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("FilledPersonAuthDocType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class FilledPersonAuthDocTypeCt : CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("PresentedDocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PresentedDocumentModeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Признак представления документа: 0 - документ не представлен при подаче ДТ; 1 - документ представлен при подаче ДТ; 2 - документ не  представлен в соответствии с частью 1 п.2 ст. 80 ТК ЕАЭС; 3 - документ представлен (будет представлен) после выпуска товаров</remarks>
        [LxElementValue("ProvidingIndicationMark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? ProvidingIndicationMark { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные технологические идентификаторы документа, удостоверяющего полномочия декларанта (для РФ)</remarks>
        [LxElementCt("RFPresentedDocID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt RFPresentedDocID { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GoodsGroupDescriptionType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Описание группы товаров одного наименования с отличающимися от других групп характеристиками</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:GoodsGroupDescriptionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2107:2-2143:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsGroupDescriptionType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsGroupDescriptionTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание группы товаров с учетом дополнительных характеристик (качественных, технических, коммерческих), необходимых для классификации товара и для исчисления таможенной стоимости. В случае отсутствия описания группы товаров указывается символ «:» (двоеточие). Гр. 31 первый подраздел</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение компонента машины в соответствии с ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("RKTNVED", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{4}|[0-9]{6}|[0-9]{8}|[0-9]{10}")]
        public System.String RKTNVED { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер (позиция) компонента товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде, в соответствии с решением таможенного органа о классификации товара в соответствии с ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("ObjectOrdinal", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String ObjectOrdinal { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Сборочный номер компонента товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде, в соответствии с решением таможенного органа о классификации товара в соответствии с ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("ComponentNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String ComponentNumber { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt" />
        /// </summary>
        /// <remarks>Характеристика товаров в группе</remarks>
        [LxElementCt("GoodsGroupInformation", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt> GoodsGroupInformations { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt>();

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер группы</remarks>
        [LxElementValue("GroupNum", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "4")]
        public System.Numerics.BigInteger? GroupNum { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GoodsGroupInformationType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Характеристика товаров в группе</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:GoodsGroupInformationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2144:2-2235:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsGroupInformationType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsGroupInformationTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование производителя (изготовителя) товара</remarks>
        [LxElementValue("Manufacturer", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String Manufacturer { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование товарного знака, объекта авторского права, смежных прав, патента  и т.д.</remarks>
        [LxElementValue("TradeMark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String TradeMark { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование места происхождения</remarks>
        [LxElementValue("ProductionPlaceName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductionPlaceName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование марки</remarks>
        [LxElementValue("GoodsMark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GoodsMark { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование модели продукта (товара)</remarks>
        [LxElementValue("GoodsModel", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GoodsModel { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор вида продукта (товара) или артикул товара</remarks>
        [LxElementValue("GoodsMarking", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GoodsMarking { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование стандарта (международного, межгосударственного, государственного, отраслевого или организации) или технических условий на товар</remarks>
        [LxElementValue("GoodsStandard", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GoodsStandard { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование сорта / сорт или группа сортов (для лесо- и пиломатериалов)</remarks>
        [LxElementValue("GoodsSort", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GoodsSort { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.WoodDescriptionDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.WoodDescriptionDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о лесоматериалах</remarks>
        [LxElementCt("WoodDescriptionDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.WoodDescriptionDetailsTypeCt WoodDescriptionDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />
        /// </summary>
        /// <remarks>Линейные размеры объекта (длина, ширина и высота)</remarks>
        [LxElementCt("Dimensions", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt Dimensions { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата производства (изготовления) товара</remarks>
        [LxElementValue("DateIssue", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DateIssue { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Уникальный идентификатор (серийный номер, код) экземпляра продукта (товара)</remarks>
        [LxElementValue("SerialNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> SerialNumbers { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товаров. Гр.31 первый подраздел</remarks>
        [LxElementCt("GoodsGroupQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt GoodsGroupQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор записи</remarks>
        [LxElementValue("RecordId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String RecordId { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер записи в группе</remarks>
        [LxElementValue("LineNum", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger? LineNum { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Цена/стоимость товарной позиции</remarks>
        [LxElementValue("InvoicedCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? InvoicedCost { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.LicenseGroupTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.LicenseGroupTypeCt" />
        /// </summary>
        /// <remarks>Сведения о разрешительном документе к товарной группе</remarks>
        [LxElementCt("LicenseGroup", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.LicenseGroupTypeCt> LicenseGroups { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.LicenseGroupTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType GoodsItemBaseType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Базовый класс для описания товара</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:GoodsItemBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2236:2-2307:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsItemBaseType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsItemBaseTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Порядковый номер декларируемого товара / номер товара по списку/ номер корректируемого товара. Гр.32</remarks>
        [LxElementValue("GoodsNumeric", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger GoodsNumeric { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение особенностей указания сведений о товарах (МПО (при декларировании товаров, пересылаемых в международных почтовых отправлениях). ЭКГ (при декларировании экспресс-грузов)). Гр.32, 2-й подраздел ДТ</remarks>
        [LxElementValue("GoodFeatures", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String GoodFeatures { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование (коммерческое, фирменное или иное традиционное наименование) товаров/ «Товары согласно прилагаемому Списку». Гр.31 первый подраздел</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара, брутто (кг). Гр. 35</remarks>
        [LxElementValue("GrossWeightQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? GrossWeightQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара, нетто (кг). Гр.38</remarks>
        [LxElementValue("NetWeightQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeightQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара, нетто без учета всех видов упаковки. Гр.38</remarks>
        [LxElementValue("NetWeightQuantity2", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeightQuantity2 { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Цена/ стоимость товара. Гр 42</remarks>
        [LxElementValue("InvoicedCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? InvoicedCost { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Трехзначный буквенный код валюты цены/ стоимости товара. По классификатору валют</remarks>
        [LxElementValue("InvoicedCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String InvoicedCurrencyCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество единиц валюты, для которой указан курс для РБ</remarks>
        [LxElementValue("InvoicedCurrencyQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "6")]
        public System.Numerics.BigInteger? InvoicedCurrencyQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Курс валюты цены/ стоимости товара</remarks>
        [LxElementValue("InvoicedCurrencyRate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "11", FractionDigits = "4")]
        public LiquidTechnologies.XmlObjects.BigDecimal? InvoicedCurrencyRate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Таможенная стоимость товара. Гр.45</remarks>
        [LxElementValue("CustomsCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CustomsCost { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Статистическая стоимость декларируемого товара. Гр. 46</remarks>
        [LxElementValue("StatisticalCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? StatisticalCost { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Общая статистическая стоимость товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде</remarks>
        [LxElementValue("TotalStatisticValueAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TotalStatisticValueAmount { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GoodsSTZType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о товарах, помещенных под таможенную процедуру СТЗ или свободного склада. гр 31 п 11</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:GoodsSTZType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2308:2-2334:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsSTZType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsSTZTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Порядковый номер строки в гр 40</remarks>
        [LxElementValue("LineNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal LineNumber { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименования товара (коммерческое, фирменное или иное традиционное наименование)</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара</remarks>
        [LxElementCt("SupplementaryQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> SupplementaryQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt" />
        /// </summary>
        /// <remarks>Описание и характеристика товаров / Описание группы товаров одного наименования с отличающимися от других групп характеристиками</remarks>
        [LxElementCt("GoodsGroupDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt> GoodsGroupDescriptions { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.GoodsGroupDescriptionTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType GuaranteeTDType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Поручительство</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:GuaranteeTDType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2335:2-2401:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GuaranteeTDType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class GuaranteeTDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование документа - Генеральный договор</remarks>
        [LxElementValue("GeneralDocName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String GeneralDocName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер генерального договора</remarks>
        [LxElementValue("GeneralNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GeneralNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата генерального договора</remarks>
        [LxElementValue("GeneralDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? GeneralDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Генеральный договор - Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("GeneralKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String GeneralKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование документа - Договор поручительства</remarks>
        [LxElementValue("GuaranteeDocName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String GuaranteeDocName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер договора поручительства</remarks>
        [LxElementValue("GuaranteeNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String GuaranteeNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата договора поручительства</remarks>
        [LxElementValue("GuaranteeDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? GuaranteeDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Договор поручительства - Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("GuaranteeKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String GuaranteeKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование документа - Дополнение к договору поручительства</remarks>
        [LxElementValue("AddGuaranteeDocName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String AddGuaranteeDocName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер дополнение к договору поручительства</remarks>
        [LxElementValue("AddGuaranteeNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String AddGuaranteeNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата дополнение к договору поручительства</remarks>
        [LxElementValue("AddGuaranteeDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? AddGuaranteeDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Дополнение к договору поручительства - Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("AddGuaranteeKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String AddGuaranteeKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType IdentificationMeansDataUnitDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Символьное представление блока информации, содержащейся в коде идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IdentificationMeansDataUnitDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2402:2-2418:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentificationMeansDataUnitDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IdentificationMeansDataUnitDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой идентификатор применения блока информации, содержащейся в коде идентификации</remarks>
        [LxElementValue("AIId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{2,4}")]
        public System.String AIId { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Значение блока информации, содержащейся в коде идентификации, представленное в виде последовательности символов</remarks>
        [LxElementValue("IdentifacationMeansUnitCharacterValueId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "100")]
        public System.String IdentifacationMeansUnitCharacterValueId { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType IdentificationMeansDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о средствах идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IdentificationMeansDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2419:2-2440:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentificationMeansDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IdentificationMeansDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код уровня маркировки в соответствии со справочником уровней маркировки</remarks>
        [LxElementValue("AggregationKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String AggregationKindCode { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansListDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansListDetailsTypeCt" />
        /// </summary>
        /// <remarks>Перечень кодов идентификации</remarks>
        [LxElementCt("IdentificationMeansListDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansListDetailsTypeCt IdentificationMeansListDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansRangeDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansRangeDetailsTypeCt" />
        /// </summary>
        /// <remarks>Диапазон значений кодов идентификации</remarks>
        [LxElementCt("IdentificationMeansRangeDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansRangeDetailsTypeCt> IdentificationMeansRangeDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansRangeDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType IdentificationMeansItemDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения, размещенные на средстве идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IdentificationMeansItemDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2441:2-2457:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentificationMeansItemDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IdentificationMeansItemDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида средства идентификации, содержащего код идентификации</remarks>
        [LxElementValue("IdentificationMeansKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String IdentificationMeansKindCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDataUnitDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDataUnitDetailsTypeCt" />
        /// </summary>
        /// <remarks>Символьное представление блока информации, содержащейся в коде идентификации</remarks>
        [LxElementCt("IdentificationMeansDataUnitDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDataUnitDetailsTypeCt> IdentificationMeansDataUnitDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansDataUnitDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType IdentificationMeansListDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о перечне средств идентификации, нанесенных на товар, подлежащий маркировке средствами идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IdentificationMeansListDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2458:2-2469:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentificationMeansListDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IdentificationMeansListDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о коде идентификации</remarks>
        [LxElementCt("IdentificationMeansItemDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt> IdentificationMeansItemDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType IdentificationMeansRangeDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Диапазон значений кодов идентификации</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IdentificationMeansRangeDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2470:2-2486:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IdentificationMeansRangeDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IdentificationMeansRangeDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />
        /// </summary>
        /// <remarks>Первый номер диапазона значений кодов идентификации</remarks>
        [LxElementCt("FirstIdentificationMeansItemDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt FirstIdentificationMeansItemDetails { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt" />
        /// </summary>
        /// <remarks>Последний номер диапазона значений кодов идентификации</remarks>
        [LxElementCt("LastIdentificationMeansItemDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt LastIdentificationMeansItemDetails { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.IdentificationMeansItemDetailsTypeCt();

    }

    /// <summary>A class representing the root XSD complexType InvestmentGoodsIdDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о регистрационном номере товара (технологического оборудования, комплектующих и запасных частей к нему, сырья и материалов), указанном в перечне товаров, ввозимых для реализации инвестиционного проекта</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:InvestmentGoodsIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2487:2-2518:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("InvestmentGoodsIdDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class InvestmentGoodsIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны, в сооветствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Порядковый номер инвестиционного проекта по реестру инвестиционных проектов</remarks>
        [LxElementValue("InvestmentProjectSeqId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "4")]
        public System.String InvestmentProjectSeqId { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Год включения инвестиционного проекта в реестр инвестиционных проектов</remarks>
        [LxElementValue("InvestmentProjectYear", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdGYear, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime InvestmentProjectYear { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Кодовое обозначение вида (признака) перечня товаров, ввозимых для реализации инвестиционного проекта</remarks>
        [LxElementValue("InvestmentGoodsListKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String InvestmentGoodsListKindCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Порядковый номер товара в пределах одного инвестиционного проекта</remarks>
        [LxElementValue("InvestmentProjectGoodsSeqId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "9")]
        public System.String InvestmentProjectGoodsSeqId { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType IPObjectRegistryNumType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер объекта интеллектуальной собственности по реестру объектов интеллектуальной  собственности</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:IPObjectRegistryNumType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2519:2-2540:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("IPObjectRegistryNumType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class IPObjectRegistryNumTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Тип реестра объектов интеллектуальной собственности: 1 - единый таможенный реестр объектов интеллектуальной собственности государств - членов Евразийского экономического союза; 2 - национальный таможенный реестр объектов интеллектуальной  собственности</remarks>
        [LxElementValue("DocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String DocumentModeCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер объекта интеллектуальной собственности по реестру объектов интеллектуальной собственности</remarks>
        [LxElementValue("IPORegistryNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "(\\d{1,4})|(\\d{5}/[А-Я]{2}-\\d{6})|(\\d{5}/\\d{6}/\\d{2}-[А-Я]{2}-\\d{6})|(\\d{5}/\\d{5}-\\d{3}/[А-Я]{2}-\\d{6})|(\\d{5}/[А-Я]{2}-\\d{4}-\\d{6})")]
        public System.String IPORegistryNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType LicenseGoodsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о декларируемом товаре по лицензии</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:LicenseGoodsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2541:2-2557:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("LicenseGoodsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class LicenseGoodsTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Номер приложения/ перечня к лицензии</remarks>
        [LxElementValue("AppNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? AppNumber { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Порядковый номер декларируемого товара по приложению/перечню к лицензии</remarks>
        [LxElementValue("GoodsNumericLic", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "6")]
        public System.Numerics.BigInteger GoodsNumericLic { get; set; }

    }

    /// <summary>A class representing the root XSD complexType LicenseGroupType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о разрешительном документе к товарной группе</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:LicenseGroupType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2558:2-2579:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("LicenseGroupType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class LicenseGroupTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AuthoritesDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADCustomsRepresCertificateTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.FilledPersonAuthDocTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV4TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.BasePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SimplePresentedDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />
        /// </summary>
        /// <remarks>Разрешительный документ</remarks>
        [LxElementCt("LicDocument", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt LicDocument { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Уникальный номер записи в графе 44</remarks>
        [LxElementValue("RecordId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String RecordId { get; set; } = "";

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер товара в разрешительном документе</remarks>
        [LxElementValue("GoodsNumericLic", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "6")]
        public System.Numerics.BigInteger? GoodsNumericLic { get; set; }

    }

    /// <summary>A class representing the root XSD complexType MechanismUnitType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о функциональном блоке</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:MechanismUnitType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2580:2-2600:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("MechanismUnitType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class MechanismUnitTypeCt : CustomsLiquidXml.XSD.CatESADCu.ComponentDescriptionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование ФБ / Раздела списка (ПРОЧИЕ КОМПОНЕНТЫ)</remarks>
        [LxElementValue("UnitDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String UnitDescription { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.MechUnitPartTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.MechUnitPartTypeCt" />
        /// </summary>
        /// <remarks>Сведения о компоненте функционального блока</remarks>
        [LxElementCt("MechUnitPart", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.MechUnitPartTypeCt> MechUnitParts { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.MechUnitPartTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType MechUnitPartType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о компоненте функционального блока</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:MechUnitPartType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2601:2-2616:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("MechUnitPartType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class MechUnitPartTypeCt : CustomsLiquidXml.XSD.CatESADCu.ComponentDescriptionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование компоненты</remarks>
        [LxElementValue("PartDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String PartDescription { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType PackagePalleteInformationType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о грузе, таре, упаковке, поддоне</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:PackagePalleteInformationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2617:2-2647:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PackagePalleteInformationType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class PackagePalleteInformationTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>
        ///   Кодовое обозначение вида информации ( 0 – сведения об упаковке;<br/>
        ///   1 – сведения о таре;<br/>
        ///   2 – сведения о грузе;<br/>
        ///   3 – сведения о поддонах;<br/>
        ///   4 – сведения об индивидуальной упаковке)
        /// </remarks>
        [LxElementValue("InfoKindCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String InfoKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида груза, упаковки или упаковочного материала</remarks>
        [LxElementValue("PalleteCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String PalleteCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество упаковок, поддонов</remarks>
        [LxElementValue("PalleteQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "8")]
        public System.Numerics.BigInteger? PalleteQuantity { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание</remarks>
        [LxElementValue("CargoDescriptionText", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> CargoDescriptionTexts { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType PaymentSheduleDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об этапе уплаты платежа</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:PaymentSheduleDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>580:2-596:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PaymentSheduleDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class PaymentSheduleDetailsTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Порядковый номер этапа</remarks>
        [LxElementValue("ObjectOrdinal", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger ObjectOrdinal { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Последний день этапа</remarks>
        [LxElementValue("EndDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime EndDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PrecedingDocumentType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Предшествующий документ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:PrecedingDocumentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2648:2-2734:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PrecedingDocumentType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class PrecedingDocumentTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер строки</remarks>
        [LxElementValue("LineNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "5", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? LineNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Дополнительный идентификатор предшествующего документа</remarks>
        [LxElementValue("PrecedingDocumentID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PrecedingDocumentID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенного органа предшествующего документа</remarks>
        [LxElementValue("PrecedingDocumentCustomsCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String PrecedingDocumentCustomsCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Предшествующий документ - дата</remarks>
        [LxElementValue("PrecedingDocumentDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? PrecedingDocumentDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Предшествующий документ - регистрационный номер декларации на товары, транзитной декларации, заявления о выпуске товаров до подачи декларации на товары или заявления о совершении операций в отношении временно вывезенных транспортных средств международной перевозки, являющихся товарами, помещенными под таможенную процедуру временного ввоза (допуска)</remarks>
        [LxElementValue("PrecedingDocumentNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String PrecedingDocumentNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Предшествующий документ - Номер (идентификатор) вносимых изменений и (или) дополнений</remarks>
        [LxElementValue("PrecedingDocumentOrdinalId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "2")]
        public System.String PrecedingDocumentOrdinalId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Предшествующий документ - дополнительная составляющая 3ей части номера</remarks>
        [LxElementValue("AddNumberPart", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "2")]
        public System.String AddNumberPart { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DTMDocDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DTMDocDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер декларации на транспортное средство</remarks>
        [LxElementCt("DTMDocDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DTMDocDetailsTypeCt DTMDocDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер предварительной информации</remarks>
        [LxElementValue("PIDocumentNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String PIDocumentNumber { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.TIRIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.TIRIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер книжки МДП</remarks>
        [LxElementCt("TIRIdDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.TIRIdDetailsTypeCt TIRIdDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер иного предшествующего документа</remarks>
        [LxElementValue("OtherPrDocumentNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String OtherPrDocumentNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата регистрации иного предшествующего документа</remarks>
        [LxElementValue("OtherPrDocumentDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? OtherPrDocumentDate { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Номер товара в предшествующем документе</remarks>
        [LxElementValue("PrecedingDocumentGoodsNumeric", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? PrecedingDocumentGoodsNumeric { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование предшествующего документа</remarks>
        [LxElementValue("PrecedingDocumentName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String PrecedingDocumentName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида предшествующего документа в соответствии с классификатором видов документов</remarks>
        [LxElementValue("PrecedingDocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PrecedingDocumentModeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара по ТН ВЭД ЕАЭС в предшествующем документе (для РФ и КР)</remarks>
        [LxElementValue("PrcDocGoodsTNVEDCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{4}|[0-9]{6}|[0-9]{8}|[0-9]{10}")]
        public System.String PrcDocGoodsTNVEDCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ProcessingGoodsCostInfoType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о стоимости операций по переработке товаров, помещенных под таможенную процедуру переработки товаров вне таможенной территории</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ProcessingGoodsCostInfoType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2735:2-2751:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ProcessingGoodsCostInfoType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ProcessingGoodsCostInfoTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Стоимость операций по переработке товаров, помещенных под таможенную процедуру переработки товаров вне таможенной территории</remarks>
        [LxElementValue("ProcessingGoodsCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal ProcessingGoodsCost { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Трехзначный буквенный код валюты стоимости операций по переработке товаров, помещенных под таможенную процедуру переработки товаров вне таможенной территории, в соответствии с Классификатором валют</remarks>
        [LxElementValue("ProcessingGoodsCostCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String ProcessingGoodsCostCurrencyCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType ProcessingGoodsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Описание продуктов переработки</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:ProcessingGoodsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2752:2-2773:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ProcessingGoodsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class ProcessingGoodsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара по ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("GoodsTNVEDCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4,10}")]
        public System.String GoodsTNVEDCode { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание и характеристика товара</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товаров в единице измерения</remarks>
        [LxElementCt("ProcessingGoodsQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> ProcessingGoodsQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType RangeMeasureType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Диапазон величин (с указанием единиц измерения)</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:RangeMeasureType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2774:2-2790:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RangeMeasureType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class RangeMeasureTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Минимальная величина диапазона величин (с указанием единиц измерения)</remarks>
        [LxElementCt("MinRangeMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt MinRangeMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Максимальная величина диапазона величин (с указанием единиц измерения)</remarks>
        [LxElementCt("MaxRangeMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt MaxRangeMeasure { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RBGoodsReleaseNumberType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер выпуска товаров (для РБ)</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:RBGoodsReleaseNumberType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2791:2-2807:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RBGoodsReleaseNumberType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class RBGoodsReleaseNumberTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер регистрации выпуска товаров</remarks>
        [LxElementValue("ReleaseNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "8")]
        public System.String ReleaseNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType RFBasePresentedDocIDType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Технологические идентификаторы представленного документа (для РФ)</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:RFBasePresentedDocIDType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2808:2-2829:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RFBasePresentedDocIDType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class RFBasePresentedDocIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор документа, присвоенный информационной системой таможенных органов при представлении документа в электронном виде</remarks>
        [LxElementValue("ElectronicDocumentID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String ElectronicDocumentID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор хранилища электронных документов при представлении документа в электронном виде</remarks>
        [LxElementValue("ElectronicArchID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String ElectronicArchID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представленного документа в соответствии с альбомом форматов электронных форм документов</remarks>
        [LxElementValue("DocumentModeID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String DocumentModeID { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RFPresentedDocIDType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Дополнительные технологические идентификаторы представленного документа (для РФ)</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:RFPresentedDocIDType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2830:2-2855:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RFPresentedDocIDType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class RFPresentedDocIDTypeCt : CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("PresentedDocumentModeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PresentedDocumentModeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Признак представления документа: 1 - документ представлен при подаче ДТ; 2 - документ не представлен в соответствии с частью 1 п.2 ст. 80 ТК ЕАЭС</remarks>
        [LxElementValue("ProvidingIndicationMark", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? ProvidingIndicationMark { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер таможенного документа, с которым он был первоначально представлен</remarks>
        [LxElementValue("RegNumberDocument", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String RegNumberDocument { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RFTechMarkType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Технологические отметки для РФ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:RFTechMarkType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2856:2-2867:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RFTechMarkType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class RFTechMarkTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные технологические характеристики документов, удостоверяющих личность, удостоверяющих полномочия лица, подающего таможенную декларацию, и подтверждающих договорные отношения декларанта с таможенным представителем</remarks>
        [LxElementCt("RFTechDocumentId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt> RFTechDocumentIds { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType SubjectBaseDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Компоненты, представляющие базовый набор сведений о субъекте</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:SubjectBaseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2868:2-2898:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SubjectBaseDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class SubjectBaseDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedCode20TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UnifiedCode20TypeCt" />
        /// </summary>
        /// <remarks>Кодовое обозначение организационно-правовой формы, в которой зарегистрирован хозяйствующий субъект</remarks>
        [LxElementCt("BusinessEntityTypeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UnifiedCode20TypeCt BusinessEntityTypeCode { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование организационно-правовой формы, в которой зарегистрирован хозяйствующий субъект</remarks>
        [LxElementValue("BusinessEntityTypeName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "150")]
        public List<System.String> BusinessEntityTypeNames { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.UITN40TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.UITN40TypeCt" />
        /// </summary>
        /// <remarks>Уникальный идентификационный таможенный номер, присвоенный юридическому или физическому лицу</remarks>
        [LxElementCt("UITN", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.UITN40TypeCt UITN { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SupplyConsigneeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Получатель поставки. Для РФ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:SupplyConsigneeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2899:2-2914:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SupplyConsigneeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class SupplyConsigneeTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SupplyConsignorType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Отправитель поставки. Для РФ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:SupplyConsignorType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2915:2-2930:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SupplyConsignorType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class SupplyConsignorTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SupplyInformationsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Описание поставки товаров. Для РФ</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:SupplyInformationsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2931:2-2972:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SupplyInformationsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class SupplyInformationsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Страна происхождения</remarks>
        [LxElementValue("OriginCountryName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String OriginCountryName { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Условная таможенная стоимость</remarks>
        [LxElementValue("CustomsCost", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CustomsCost { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код валюты</remarks>
        [LxElementValue("ContractCurrencyCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String ContractCurrencyCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsRUTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.DeliveryTermsRUTypeCt" />
        /// </summary>
        /// <remarks>Условия поставки.</remarks>
        [LxElementCt("DeliveryTerms", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.DeliveryTermsRUTypeCt DeliveryTerms { get; set; } = new CustomsLiquidXml.XSD.CatRu.DeliveryTermsRUTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара в единицах измерения.</remarks>
        [LxElementCt("GoodsQuantity", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> GoodsQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsignorTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsignorTypeCt" />
        /// </summary>
        /// <remarks>Отправитель поставки.</remarks>
        [LxElementCt("SupplyConsignor", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.SupplyConsignorTypeCt SupplyConsignor { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsigneeTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.SupplyConsigneeTypeCt" />
        /// </summary>
        /// <remarks>Получатель поставки.</remarks>
        [LxElementCt("SupplyConsignee", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.SupplyConsigneeTypeCt SupplyConsignee { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TDGuaranteeType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Гарантия для ТД</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:TDGuaranteeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>2973:2-3044:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TDGuaranteeType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class TDGuaranteeTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код меры обеспечения по классификатору мер обеспечения</remarks>
        [LxElementValue("MeasureCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "\\d{2}")]
        public System.String MeasureCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер документа</remarks>
        [LxElementValue("DocNumber", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DocNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата документа</remarks>
        [LxElementValue("DocDate", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocDate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DTMDocDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о регистрационном номере сертификата обеспечения исполнения обязанности по уплате таможенных пошлин, налогов</remarks>
        [LxElementCt("GuaranteeCertificateIdDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt GuaranteeCertificateIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, подтверждающем применение мер обеспечения соблюдения таможенного транзита</remarks>
        [LxElementCt("TransitGuaranteeDocDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt TransitGuaranteeDocDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида гарантии, указанное в соответствии с законодательством государства-члена</remarks>
        [LxElementValue("NationalGuaranteeCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String NationalGuaranteeCode { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Кодовое обозначение страны, в которой гарантия недействительна</remarks>
        [LxElementValue("NonGuaranteeCountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public List<System.String> NonGuaranteeCountryCodes { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, подтверждающем включение лица в реестр таможенных перевозчиков или в реестр уполномоченных экономических операторов</remarks>
        [LxElementCt("RegisterDocumentIdDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt RegisterDocumentIdDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование гаранта</remarks>
        [LxElementValue("GuaranteeName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String GuaranteeName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Учетный номер плательщика (УНП)</remarks>
        [LxElementValue("UNP", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String UNP { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код МФО/БИК</remarks>
        [LxElementValue("BIC", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{9}")]
        public System.String BIC { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сумма обеспечения. Для РБ</remarks>
        [LxElementValue("GuaranteeAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? GuaranteeAmount { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GuaranteeTDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GuaranteeTDTypeCt" />
        /// </summary>
        /// <remarks>Поручительство</remarks>
        [LxElementCt("GuaranteeTD", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.GuaranteeTDTypeCt GuaranteeTD { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TIRIdDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер книжки МДП</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:TIRIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3045:2-3061:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIRIdDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class TIRIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Серия книжки МДП</remarks>
        [LxElementValue("TIRSeries", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String TIRSeries { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер книжки МДП</remarks>
        [LxElementValue("TIRID", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "8")]
        public System.String TIRID { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType TransportMeansRegistrationIdDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о транспортном средстве</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:TransportMeansRegistrationIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3062:2-3082:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransportMeansRegistrationIdDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class TransportMeansRegistrationIdDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.TransportMeansBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер (идентификатор) первого прицепного транспортного средства</remarks>
        [LxElementValue("FirstTrailerRegId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String FirstTrailerRegId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер (идентификатор) второго прицепного транспортного средства</remarks>
        [LxElementValue("SecondTrailerRegId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String SecondTrailerRegId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UITN40Type@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об идентификационном (уникальном идентификационном) таможенном номере</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:UITN40Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3083:2-3099:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UITN40Type", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class UITN40TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код. Универсальный идентификационный таможенный номер. Строка не более 40 символов</remarks>
        [LxElementValue("UITNCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String UITNCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны, по правилам которой сформирован указанный идентификатор</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UnifiedCode20Type@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Строка символов, представляющая краткое условное обозначение объекта в соответствии со справочником (классификатором), заданным с помощью контекстной характеристики, содержащая не более 20 символов</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:UnifiedCode20Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3100:2-3116:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UnifiedCode20Type", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class UnifiedCode20TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код объекта в соответсвии со справочником (классификатором)</remarks>
        [LxElementValue("UnifiedCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String UnifiedCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Обозначение справочника (классификатора), в соответствии с которым указан код</remarks>
        [LxElementValue("CodeListId", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String CodeListId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UnifiedPhysicalMeasureType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Числовая величина с заданной точностью, определенная в результате измерения физических параметров в каких-либо единицах измерения</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:UnifiedPhysicalMeasureType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3117:2-3138:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UnifiedPhysicalMeasureType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class UnifiedPhysicalMeasureTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Количество в единице измерения</remarks>
        [LxElementValue("MeasuredAmount", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0.000001", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal MeasuredAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Условное обозначение единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String MeasureUnitQualifierName { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierCode", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String MeasureUnitQualifierCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType WoodDescriptionDetailsType@urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о лесоматериалах</remarks>
    /// <XsdPath>schema:CUESADCommonAggregateTy...xsd/complexType:WoodDescriptionDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\CUESADCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>3139:2-3185:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("WoodDescriptionDetailsType", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0")]
    public partial class WoodDescriptionDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование сортимента (для лесоматериалов товарной позиции 4403)</remarks>
        [LxElementValue("WoodSortiment", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "30")]
        public System.String WoodSortiment { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Порода древесины</remarks>
        [LxElementValue("WoodKind", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String WoodKind { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование сорта (группы сортов) продукта (товара)</remarks>
        [LxElementValue("ProductSortName", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductSortName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />
        /// </summary>
        /// <remarks>Сведения о величине припуска по длине, ширине и высоте</remarks>
        [LxElementCt("AllowanceDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt AllowanceDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt" />
        /// </summary>
        /// <remarks>Сведения о величине отклонений по длине, ширине и высоте</remarks>
        [LxElementCt("DeviationDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DimensionTypeCt DeviationDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RangeMeasureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RangeMeasureTypeCt" />
        /// </summary>
        /// <remarks>Сведения о диапазоне диаметров</remarks>
        [LxElementCt("DiameterRangeDetails", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RangeMeasureTypeCt DiameterRangeDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Объем товара в соответствии с контрактом</remarks>
        [LxElementCt("ContractVolumeMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt ContractVolumeMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Фактический объем товара</remarks>
        [LxElementCt("FactVolumeMeasure", "urn:customs.ru:CUESADCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt FactVolumeMeasure { get; set; }

    }

    #endregion

}

namespace CustomsLiquidXml.XSD.RUScatRu
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType AEORegistryIdDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Свеидетельство о включении лица в реестр таможенных перевозчиков или в реестр уполномоченных экономических операторов</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:AEORegistryIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>9:2-40:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AEORegistryIdDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class AEORegistryIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код типа реестра уполномоченных экономических операторов</remarks>
        [LxElementValue("RegistryOwnerCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String RegistryOwnerCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер свидетельства, присвоенный уполномоченным органом государства-члена</remarks>
        [LxElementValue("DocId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DocId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код типа свидетельства уполномоченного экономического оператора</remarks>
        [LxElementValue("AEORegistryKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String AEORegistryKindCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение признака перерегистрации документа</remarks>
        [LxElementValue("ReregistrationCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String ReregistrationCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType AmountNType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Денежная сумма и цифровой код валюты</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:AmountNType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>58:2-74:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AmountNType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class AmountNTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Сумма</remarks>
        [LxElementValue("Amount", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal Amount { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Цифровой код валюты в соответствии с Классификатором валют</remarks>
        [LxElementValue("CurrencyCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String CurrencyCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType AmountType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Денежная сумма и код валюты</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:AmountType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>41:2-57:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AmountType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class AmountTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Сумма</remarks>
        [LxElementValue("Amount", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal Amount { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Буквенный код валюты в соответствии с Классификатором валют</remarks>
        [LxElementValue("CurrencyCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String CurrencyCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType BusinessEntityId20Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Строка символов, идентифицирующая хозяйствующего субъекта</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:BusinessEntityId20Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>75:2-91:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("BusinessEntityId20Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class BusinessEntityId20TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Идентификатор хозяйствующего субъекта. Строка не более 20 символов</remarks>
        [LxElementValue("BusinessEntityId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String BusinessEntityId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Метод идентификации хозяйствующих субъектов. Строка не более 20 символов</remarks>
        [LxElementValue("KindId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String KindId { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType CarrierRepresentativeDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Cведения о лице, являющемся сотрудником или уполномоченным представителем организации-перевозчика</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:CarrierRepresentativeDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>92:2-117:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CarrierRepresentativeDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class CarrierRepresentativeDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактный реквизит лица</remarks>
        [LxElementCt("CommunicationDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt CommunicationDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt IdentityCard { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение роли, выполняемой лицом</remarks>
        [LxElementValue("RoleCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String RoleCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CountryDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о стране</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:CountryDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>118:2-134:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CountryDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class CountryDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CountryName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CountryDetailsV3Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о стране</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:CountryDetailsV3Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>135:2-156:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CountryDetailsV3Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class CountryDetailsV3TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CountryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы административно-территориального деления</remarks>
        [LxElementValue("TerritoryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{8,17}")]
        public System.String TerritoryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CustomsPersonDetails@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о должностном лице таможенного органа</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:CustomsPersonDetails</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>157:2-177:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CustomsPersonDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class CustomsPersonDetailsCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ЛНП должностного лица таможенного органа</remarks>
        [LxElementValue("LNP", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "4")]
        public System.String LNP { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенного органа, указанный на оттиске ЛНП</remarks>
        [LxElementValue("CustomsCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DeliveryTermsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Условия поставки товаров</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:DeliveryTermsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>178:2-199:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeliveryTermsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class DeliveryTermsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование географического пункта или места передачи товаров</remarks>
        [LxElementValue("DeliveryPlace", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DeliveryPlace { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код условий поставки в соответствии с классификатором условий поставки</remarks>
        [LxElementValue("DeliveryTermsStringCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\D{3}")]
        public System.String DeliveryTermsStringCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида поставки товаров в соответствии с классификатором видов поставок товаров, подлежащих учету при осуществлении экспортных операций, применяемым в Республике Беларусь</remarks>
        [LxElementValue("DeliveryTermsRBCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String DeliveryTermsRBCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocBaseType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о базовых реквизитах документа</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:DocBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>200:2-225:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocBaseType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class DocBaseTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocStartDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocStartDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocBaseV2Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о базовых реквизитах документа</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:DocBaseV2Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>226:2-251:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocBaseV2Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class DocBaseV2TypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocStartDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocStartDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocBaseV4Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие детализированную информацию о документе</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:DocBaseV4Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>252:2-267:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocBaseV4Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class DocBaseV4TypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType EECCustomsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Таможенный орган ЕАЭС</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:EECCustomsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>268:2-283:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECCustomsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class EECCustomsTypeCt : CustomsLiquidXml.XSD.CatRu.CustomsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType EECDTGoodsBaseDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие базовые сведения о товаре в таможенной декларации</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:EECDTGoodsBaseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>284:2-309:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECDTGoodsBaseDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class EECDTGoodsBaseDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.EECGoodsBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара, брутто</remarks>
        [LxElementValue("UnifiedGrossMassMeasure", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? UnifiedGrossMassMeasure { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Вес товара, нетто</remarks>
        [LxElementValue("UnifiedNetMassMeasure", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? UnifiedNetMassMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара с указанием дополнительной единицы измерения</remarks>
        [LxElementCt("GoodsMeasureDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> GoodsMeasureDetails { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType EECEDocHeaderAddInfoType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Дополнительные технологические реквизиты электронного документа (сведений)</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:EECEDocHeaderAddInfoType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>310:2-336:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECEDocHeaderAddInfoType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class EECEDocHeaderAddInfoTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение сообщения общего процесса</remarks>
        [LxElementValue("InfEnvelopeCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "P\\.[A-Z]{2}\\.[0-9]{2}\\.MSG\\.[0-9]{3}")]
        public System.String InfEnvelopeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Кодовое обозначение электронного документа (сведений) в соответствии с реестром структур электронных документов и сведений</remarks>
        [LxElementValue("EDocCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "R(\\.[A-Z]{2}\\.[A-Z]{2}\\.[0-9]{2})?\\.[0-9]{3}")]
        public System.String EDocCode { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата и время создания электронного документа (сведений)</remarks>
        [LxElementValue("EDocDateTime", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime EDocDateTime { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение языка</remarks>
        [LxElementValue("LanguageCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}")]
        public System.String LanguageCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType EECGoodsBaseType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие базовые сведения о товаре</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:EECGoodsBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>337:2-358:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECGoodsBaseType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class EECGoodsBaseTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер товара</remarks>
        [LxElementValue("GoodsNumeric", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? GoodsNumeric { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код товара по ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("GoodsTNVEDCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4,10}")]
        public System.String GoodsTNVEDCode { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание товара, включая торговое, коммерческое или иное традиционное наименование товара</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType EECGoodsManufacturerDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о производителе товара</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:EECGoodsManufacturerDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>359:2-380:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("EECGoodsManufacturerDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class EECGoodsManufacturerDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Сведения о производителе товара</remarks>
        [LxElementValue("ManufacturerName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ManufacturerName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование товарного знака, объекта авторского права, смежных прав, патента</remarks>
        [LxElementValue("TradeMarkName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String TradeMarkName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование места происхождения</remarks>
        [LxElementValue("ProductionPlaceName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductionPlaceName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ExchangeRateWithCurrencyA3Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Курс валюты</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:ExchangeRateWithCurrencyA3Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>381:2-402:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ExchangeRateWithCurrencyA3Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class ExchangeRateWithCurrencyA3TypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Курс валюты. Число. Всего 20 цифр из них до 4 знаков после запятой</remarks>
        [LxElementValue("CurrencyRate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "20", FractionDigits = "4")]
        public LiquidTechnologies.XmlObjects.BigDecimal CurrencyRate { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Буквенный код валюты в соответствии с Классификатором валют</remarks>
        [LxElementValue("CurrencyA3Code", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String CurrencyA3Code { get; set; } = "";

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Масштаб денежной суммы в десятичной системе счисления, представленный в виде показателя степени числа 10</remarks>
        [LxElementValue("ScaleNumber", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "2")]
        public System.Numerics.BigInteger? ScaleNumber { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GoodLocationTransportMeansDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о транспортном средстве в/на котором находятся товары</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:GoodLocationTransportMeansDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>403:2-419:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodLocationTransportMeansDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class GoodLocationTransportMeansDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида транспорта</remarks>
        [LxElementValue("UnifiedTransportModeCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String UnifiedTransportModeCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.TransportMeansRegIdTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.TransportMeansRegIdTypeCt" />
        /// </summary>
        /// <remarks>Индивидуальное буквенно-цифровое обозначение, присвоенное регистрирующим органом транспортному средству</remarks>
        [LxElementCt("TransportMeansRegId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUScatRu.TransportMeansRegIdTypeCt> TransportMeansRegIds { get; } = new List<CustomsLiquidXml.XSD.RUScatRu.TransportMeansRegIdTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType InvoiceValueBaseDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие базовые сведения о стоимости товара по контракту</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:InvoiceValueBaseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>420:2-436:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("InvoiceValueBaseDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class InvoiceValueBaseDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt" />
        /// </summary>
        /// <remarks>Общая стоимость товаров в валюте цены договора или в валюте платежа (оценки)</remarks>
        [LxElementCt("ValueAmount", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt ValueAmount { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.ExchangeRateWithCurrencyA3TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.ExchangeRateWithCurrencyA3TypeCt" />
        /// </summary>
        /// <remarks>Курс валюты цены договора или валюты платежа (оценки)</remarks>
        [LxElementCt("ExchangeRate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.ExchangeRateWithCurrencyA3TypeCt ExchangeRate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType OrganizationType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о юридическом лице</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:OrganizationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>437:2-457:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("OrganizationType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class OrganizationTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBaseDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес</remarks>
        [LxElementCt("SubjectAddressDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt SubjectAddressDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактный реквизит субъекта</remarks>
        [LxElementCt("CommunicationDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt CommunicationDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PeriodDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие промежуток времени с указанием начальной и конечной дат и времени</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:PeriodDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>458:2-474:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PeriodDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class PeriodDetailsTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата и время начала действия</remarks>
        [LxElementValue("StartDateTime", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? StartDateTime { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата и время окончания действия</remarks>
        [LxElementValue("EndDateTime", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EndDateTime { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RegisterDocumentIdDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Свеидетельство о включении лица в реестр уполномоченных экономических операторов</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RegisterDocumentIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>475:2-501:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegisterDocumentIdDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RegisterDocumentIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Регистрационный номер лица, присвоенный ему при включении в реестр, или регистрационный номер документа о включении лица в реестр</remarks>
        [LxElementValue("RegistrationNumberId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String RegistrationNumberId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение признака перерегистрации документа</remarks>
        [LxElementValue("ReregistrationCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String ReregistrationCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа свидетельства уполномоченного экономического оператора</remarks>
        [LxElementValue("AEORegistryKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String AEORegistryKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RegisterOrganizationDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о реквизитах юридического лица, включенного в реестр</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RegisterOrganizationDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>502:2-532:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegisterOrganizationDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RegisterOrganizationDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBaseDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес регистрации юридического лица</remarks>
        [LxElementCt("AddressDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt AddressDetails { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактный реквизит</remarks>
        [LxElementCt("CommunicationDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.ContactTypeCt> CommunicationDetails { get; } = new List<CustomsLiquidXml.XSD.CatRu.ContactTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Информация о почтовом адресе юридического лица</remarks>
        [LxElementCt("PostalAddressDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt PostalAddressDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак филиала организации: 0 - головная организация (основное подразделение); 1 - филиал организации (структурное подразделение)</remarks>
        [LxElementValue("BranchFlagCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String BranchFlagCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ResourceItemStatusDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие детализированную информацию о состоянии записи общего ресурса</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:ResourceItemStatusDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>533:2-549:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ResourceItemStatusDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class ResourceItemStatusDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.PeriodDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.PeriodDetailsTypeCt" />
        /// </summary>
        /// <remarks>Период действия записи общего ресурса (реестра, перечня, базы данных)</remarks>
        [LxElementCt("ValidityPeriodDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.PeriodDetailsTypeCt ValidityPeriodDetails { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата и время обновления записи общего ресурса (реестра, перечня, базы данных)</remarks>
        [LxElementValue("UpdateDateTime", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? UpdateDateTime { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RUAddressType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Адрес организации / физического лица</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RUAddressType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>550:2-651:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RUAddressType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RUAddressTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида адреса: "1" - адрес регистрации; "2" - фактический адрес; "3" - почтовый адрес</remarks>
        [LxElementValue("AddressKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String AddressKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Почтовый индекс</remarks>
        [LxElementValue("PostalCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "9")]
        public System.String PostalCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Буквенный код страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое название страны в соответствии с классификатором стран мира</remarks>
        [LxElementValue("CounryName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String CounryName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регион (Наименование единицы административно-территориального деления первого уровня)</remarks>
        [LxElementValue("Region", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String Region { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Район (Наименование единицы административно-территориального деления второго уровня)</remarks>
        [LxElementValue("District", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String District { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Город</remarks>
        [LxElementValue("Town", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String Town { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Населенный пункт</remarks>
        [LxElementValue("City", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String City { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Улица (Наименование элемента улично-дорожной сети городской инфраструктуры)</remarks>
        [LxElementValue("StreetHouse", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String StreetHouse { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Обозначение дома, корпуса, строения</remarks>
        [LxElementValue("House", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String House { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Обозначение офиса или квартиры</remarks>
        [LxElementValue("Room", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String Room { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Набор элементов адреса, представленных в свободной форме в виде текста.</remarks>
        [LxElementValue("AddressText", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "1000")]
        public System.String AddressText { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код ОКТМО (Общероссийский классификатор территорий муниципальных образований)</remarks>
        [LxElementValue("OKTMO", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "11")]
        public System.String OKTMO { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код ОКАТО (Общероссийский классификатор объектов административно-территориального деления)</remarks>
        [LxElementValue("OKATO", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{5,11}")]
        public System.String OKATO { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код КЛАДР</remarks>
        [LxElementValue("KLADR", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String KLADR { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Глобальный идентификатор адресного объекта по ФИАС</remarks>
        [LxElementValue("AOGUID", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String AOGUID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор адресного объекта по ФИАС</remarks>
        [LxElementValue("AOID", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "36")]
        public System.String AOID { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы административно-территориального деления</remarks>
        [LxElementValue("TerritoryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "17")]
        public System.String TerritoryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер абонентского ящика на предприятии почтовой связи</remarks>
        [LxElementValue("PostOfficeBoxId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String PostOfficeBoxId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RUIdentityCardType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о документе, удостоверяющем личность физического лица</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RUIdentityCardType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>652:2-713:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RUIdentityCardType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RUIdentityCardTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа, удостоверяющего личность, в соответствии с классификатором видов документов, удостоверяющих личность</remarks>
        [LxElementValue("IdentityCardCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "(\\d{2})|([A-Z]{2}\\d{5})")]
        public System.String IdentityCardCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String IdentityCardName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Полное наименование документа, удостоверяющего личность</remarks>
        [LxElementValue("FullIdentityCardName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String FullIdentityCardName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Серия документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardSeries", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "11")]
        public System.String IdentityCardSeries { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardNumber", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String IdentityCardNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата выдачи документа, удостоверяющего личность</remarks>
        [LxElementValue("IdentityCardDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? IdentityCardDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организации, выдавшей документ</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String OrganizationName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код подразделения органа, выдавшего документ, удостоверяющий личность</remarks>
        [LxElementValue("IssuerCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String IssuerCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Строка, идентифицирующая орган государственной власти государства-члена либо уполномоченную им организацию, выдавшую документ</remarks>
        [LxElementValue("AuthorityId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String AuthorityId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RUOrganizationBaseType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Реквизиты организации. Базовый класс</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RUOrganizationBaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>714:2-762:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RUOrganizationBaseType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RUOrganizationBaseTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование организации / ФИО физического лица</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "500")]
        public List<System.String> OrganizationNames { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Краткое наименование организации</remarks>
        [LxElementValue("ShortName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String ShortName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код языка для заполнения наименования</remarks>
        [LxElementValue("OrganizationLanguage", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}")]
        public System.String OrganizationLanguage { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
        [LxElementCt("RKOrganizationFeatures", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt RKOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
        [LxElementCt("RBOrganizationFeatures", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt RBOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
        [LxElementCt("RAOrganizationFeatures", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt RAOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
        [LxElementCt("KGOrganizationFeatures", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt KGOrganizationFeatures { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RUOrganizationNameAddrType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Реквизиты организации  и адрес одной строкой</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RUOrganizationNameAddrType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>763:2-778:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RUOrganizationNameAddrType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RUOrganizationNameAddrTypeCt : CustomsLiquidXml.XSD.RUScatRu.RUOrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Юридический адрес</remarks>
        [LxElementValue("Address", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "500")]
        public System.String Address { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RUOrganizationType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения об организации</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:RUOrganizationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>779:2-809:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RUOrganizationType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class RUOrganizationTypeCt : CustomsLiquidXml.XSD.RUScatRu.RUOrganizationBaseTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес организации</remarks>
        [LxElementCt("Address", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt Address { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий личность</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt IdentityCard { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактная информация</remarks>
        [LxElementCt("Contact", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt Contact { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Полные данные по организации одной строкой (при отсутствии детализации)</remarks>
        [LxElementValue("OrganizationFullDatas", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "500")]
        public List<System.String> OrganizationFullDatass { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType SigningDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие детализированную информацию о подписании документа</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SigningDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>810:2-830:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SigningDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SigningDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Сведения о контактных реквизитах</remarks>
        [LxElementCt("CommunicationDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt CommunicationDetails { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата подписания</remarks>
        [LxElementValue("SigningDate", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDateTime, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime SigningDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SubjectBaseDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие базовый набор сведений о субъекте</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SubjectBaseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>831:2-861:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SubjectBaseDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SubjectBaseDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.UnifiedCode20TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.UnifiedCode20TypeCt" />
        /// </summary>
        /// <remarks>Кодовое обозначение организационно-правовой формы, в которой зарегистрирован хозяйствующий субъект</remarks>
        [LxElementCt("BusinessEntityTypeCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.UnifiedCode20TypeCt BusinessEntityTypeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организационно-правовой формы, в которой зарегистрирован хозяйствующий субъект</remarks>
        [LxElementValue("BusinessEntityTypeName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "300")]
        public System.String BusinessEntityTypeName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.UITN40TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.UITN40TypeCt" />
        /// </summary>
        /// <remarks>Уникальный идентификационный таможенный номер, присвоенный юридическому или физическому лицу</remarks>
        [LxElementCt("UITN", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.UITN40TypeCt UITN { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SubjectBranchDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о субъекте</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SubjectBranchDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>862:2-877:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SubjectBranchDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SubjectBranchDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.OrganizationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.OrganizationTypeCt" />
        /// </summary>
        /// <remarks>Сведения об обособленном подразделении</remarks>
        [LxElementCt("SubjectBranch", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.OrganizationTypeCt SubjectBranch { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SubjectDetailsBankType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения об организации, включая банковские счета</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SubjectDetailsBankType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>909:2-924:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SubjectDetailsBankType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SubjectDetailsBankTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt" />
        /// </summary>
        /// <remarks>Информация о банковских счетах</remarks>
        [LxElementCt("BankInformation", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt> BankInformations { get; } = new List<CustomsLiquidXml.XSD.CatRu.BankInformationTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType SubjectDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Компоненты, представляющие детализированную информацию о субъекте</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SubjectDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>878:2-908:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SubjectDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SubjectDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBaseDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор физического лица</remarks>
        [LxElementValue("PersonId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String PersonId { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, удостоверяющем личность физического лица</remarks>
        [LxElementCt("IdentityCard", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt IdentityCard { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес</remarks>
        [LxElementCt("SubjectAddressDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt> SubjectAddressDetails { get; } = new List<CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.ContactTypeCt" />
        /// </summary>
        /// <remarks>Контактный реквизит субъекта</remarks>
        [LxElementCt("CommunicationDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.ContactTypeCt CommunicationDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SupplementaryQuantity24point8Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Количество в дополнительной единице измерения</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:SupplementaryQuantity24point8Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>925:2-946:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SupplementaryQuantity24point8Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class SupplementaryQuantity24point8TypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Количество товара в единице измерения</remarks>
        [LxElementValue("GoodsQuantity", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "8")]
        public LiquidTechnologies.XmlObjects.BigDecimal GoodsQuantity { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Условное обозначение единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String MeasureUnitQualifierName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения в соответствии с единицами измерения, применяемыми в ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("MeasureUnitQualifierCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String MeasureUnitQualifierCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TradeCountryDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о торгующей стране</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:TradeCountryDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>947:2-963:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TradeCountryDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class TradeCountryDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы административно-территориального деления</remarks>
        [LxElementValue("TerritoryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{8,17}")]
        public System.String TerritoryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TransportMeansRegIdType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Индивидуальное буквенно-цифровое обозначение, присвоенное регистрирующим органом транспортному средству</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:TransportMeansRegIdType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>964:2-980:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TransportMeansRegIdType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class TransportMeansRegIdTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Строка символов, идентифицирующая транспортное средство</remarks>
        [LxElementValue("TransportMeansRegIdNumber", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String TransportMeansRegIdNumber { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны, по правилам которой сформирован указанный код</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UITN40Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения об идентификационном (уникальном идентификационном) таможенном номере</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:UITN40Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>981:2-997:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UITN40Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class UITN40TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код. Универсальный идентификационный таможенный номер. Строка не более 40 символов</remarks>
        [LxElementValue("UITNCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String UITNCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны, по правилам которой сформирован указанный идентификатор</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UnifiedCode20Type@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Строка символов, представляющая краткое условное обозначение объекта в соответствии со справочником (классификатором), заданным с помощью контекстной характеристики, содержащая не более 20 символов</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:UnifiedCode20Type</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>998:2-1014:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UnifiedCode20Type", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class UnifiedCode20TypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код объекта в соответсвии со справочником (классификатором)</remarks>
        [LxElementValue("UnifiedCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String UnifiedCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Обозначение справочника (классификатора), в соответствии с которым указан код</remarks>
        [LxElementValue("CodeListId", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String CodeListId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType UnifiedPhysicalMeasureType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Числовая величина с заданной точностью, определенная в результате измерения физических параметров в каких-либо единицах измерения</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:UnifiedPhysicalMeasureType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>1015:2-1036:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("UnifiedPhysicalMeasureType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class UnifiedPhysicalMeasureTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Количество в единице измерения</remarks>
        [LxElementValue("MeasuredAmount", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0.000001", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal MeasuredAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Условное обозначение единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierName", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String MeasureUnitQualifierName { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код единицы измерения</remarks>
        [LxElementValue("MeasureUnitQualifierCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "3")]
        public System.String MeasureUnitQualifierCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType WarehouseDetailsType@urn:customs.ru:RUSCommonAggregateTypes:5.15.0</summary>
    /// <remarks>Сведения о складе</remarks>
    /// <XsdPath>schema:RUSCommonAggregateTypes.xsd/complexType:WarehouseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUSCommonAggregateTypes.xsd</XsdFile>
    /// <XsdLocation>1037:2-1083:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("WarehouseDetailsType", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0")]
    public partial class WarehouseDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес регистрации</remarks>
        [LxElementCt("AddressDetails", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt AddressDetails { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Назначение склада: 1 – склад временного хранения; 2 – таможенный склад; 3 – свободный склад</remarks>
        [LxElementValue("WarehouseKindCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "1")]
        public System.String WarehouseKindCode { get; set; } = "";

        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Тип склада: 0 – открытый; 1 – закрытый</remarks>
        [LxElementValue("TypeWarehouseIndicator", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? TypeWarehouseIndicator { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Общая площадь (кв. м)</remarks>
        [LxElementCt("TotalAreaMeasure", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt TotalAreaMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Объем помещения (куб. м)</remarks>
        [LxElementCt("CubageMeasure", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt CubageMeasure { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Код вида транспортного средства в соответствии с классификатором видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransportModeCode", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, Length = "2")]
        public List<System.String> TransportModeCodes { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Сведения о виде деятельности, осуществляемой на территории склада</remarks>
        [LxElementValue("WarehouseActivityDescriptionText", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> WarehouseActivityDescriptionTexts { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Дополнительная информация</remarks>
        [LxElementValue("AdditionalInfoText", "urn:customs.ru:RUSCommonAggregateTypes:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "4000")]
        public List<System.String> AdditionalInfoTexts { get; } = new List<System.String>();

    }

    #endregion

}

namespace CustomsLiquidXml.XSD.RUDECLcat
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType AEODeclarantDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о заявителе, включенном в реестр УЭО</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:AEODeclarantDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>12:2-27:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AEODeclarantDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class AEODeclarantDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Номер свидетельства о включении в реестр уполномоченных экономических операторов</remarks>
        [LxElementCt("AEORegistryIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt AEORegistryIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType BasePresentedDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Базовые сведения о о предоставленном документе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:BasePresentedDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>28:2-73:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("BasePresentedDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class BasePresentedDocDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида документа</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Полное наименование органа государственной власти государства-члена либо уполномоченной им организации, выдавшей документ</remarks>
        [LxElementValue("AuthorityName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "300")]
        public System.String AuthorityName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Строка символов, идентифицирующая государственный или межгосударственный орган (организацию), выдавший или утвердивший документ</remarks>
        [LxElementValue("AuthorityId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String AuthorityId { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об информационном источнике или информационном ресурсе</remarks>
        [LxElementCt("InformationSourceDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt InformationSourceDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор, используемый для целей однозначной ссылки на запись, или порядковый номер записи</remarks>
        [LxElementValue("LineId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String LineId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение электронного документа (сведений) в соответствии с реестром структур электронных документов и сведений</remarks>
        [LxElementValue("EDocCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String EDocCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы, присвоенные документу (сведениям) при размещении в хранилище электронных документов</remarks>
        [LxElementCt("DocArchIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt DocArchIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType BrokerRegistryDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о включении лица в реестр таможенных представителей</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:BrokerRegistryDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>74:2-90:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("BrokerRegistryDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class BrokerRegistryDocDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер документа о включении лица в реестр таможенных представителей или регистрационный номер лица в реестре</remarks>
        [LxElementCt("RegisterDocumentDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt RegisterDocumentDetails { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt();

    }

    /// <summary>A class representing the root XSD complexType CalculationType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Расчет размера обеспечения</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:CalculationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>91:2-197:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CalculationType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class CalculationTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида платежа  по классификатору видов налогов, сборов и иных платежей, взимание которых возложено на таможенные органы.</remarks>
        [LxElementValue("PaymentModeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "4")]
        public System.String PaymentModeCode { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Основа начисления</remarks>
        [LxElementValue("TaxBase", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? TaxBase { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты основы начисления (адвалорная ставка)</remarks>
        [LxElementValue("TaxBaseCurrencyCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String TaxBaseCurrencyCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение единицы измерения основы начисления (специфическая ставка)</remarks>
        [LxElementValue("TaxBaseQualifierCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String TaxBaseQualifierCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Вид ставки (адвалорная -"%", специфическая - "*")</remarks>
        [LxElementValue("RateTypeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RateTypeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Ставка.</remarks>
        [LxElementValue("Rate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "12", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? Rate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код единицы измерения ставки (специфическая ставка)</remarks>
        [LxElementValue("RateTNVEDQualifierCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String RateTNVEDQualifierCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты ставки (специфическая ставка)</remarks>
        [LxElementValue("RateCurrencyCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String RateCurrencyCode { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество календарных дней</remarks>
        [LxElementValue("NumberDays", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "4")]
        public System.Numerics.BigInteger? NumberDays { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Число этапов</remarks>
        [LxElementValue("NumberStages", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? NumberStages { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Число полных и неполных календарных месяцев</remarks>
        [LxElementValue("NumberMonths", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? NumberMonths { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Весовой коэффициент единицы измерения (специфическая ставка)</remarks>
        [LxElementValue("WeightingFactor", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "9", FractionDigits = "3")]
        public LiquidTechnologies.XmlObjects.BigDecimal? WeightingFactor { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата применения ставки таможенного платежа</remarks>
        [LxElementValue("RateUseDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? RateUseDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код в соответствии с классификатором особенностей уплаты таможенных и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String PaymentCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сумма платежа</remarks>
        [LxElementValue("PaymentAmount", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? PaymentAmount { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Цифровой код валюты суммы платежа</remarks>
        [LxElementValue("PaymentCurrencyCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{3}")]
        public System.String PaymentCurrencyCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер группы в соответствии с ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("TNVEDGroup", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "\\d{4,10}")]
        public System.String TNVEDGroup { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Ссылочный идентификатор записи в сведениях о предшествующем документе</remarks>
        [LxElementValue("ReferenceLineId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String ReferenceLineId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Ссылочный идентификатор записи в предшествующем документе или сведениях</remarks>
        [LxElementValue("RefReferenceLineId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String RefReferenceLineId { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер товара в предшествующем документе</remarks>
        [LxElementValue("ReferenceConsignmentItemOrdinal", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? ReferenceConsignmentItemOrdinal { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CommodityDescriptionBaseDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Компоненты, представляющие дополнительные характеристики базовых сведений товара</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:CommodityDescriptionBaseDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>198:2-248:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CommodityDescriptionBaseDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class CommodityDescriptionBaseDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.EECGoodsManufacturerDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование марки</remarks>
        [LxElementValue("ProductMarkName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductMarkName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование модели продукта</remarks>
        [LxElementValue("ProductModelName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductModelName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор вида продукции (артикул)</remarks>
        [LxElementValue("ProductId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String ProductId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование сорта (группы сортов) продукта</remarks>
        [LxElementValue("ProductSortName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductSortName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование стандарта (международного, межгосударственного, государтвенного, отраслевого или организации) или технических условий на товар</remarks>
        [LxElementValue("StandardName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String StandardName { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Уникальный идентификатор (серийный номер, код) экземпляра продукта</remarks>
        [LxElementValue("ProductInstanceId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "50")]
        public List<System.String> ProductInstanceIds { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата производства (изготовления) товара</remarks>
        [LxElementValue("ManufactureDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ManufactureDate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер объекта интеллектуальной собственности по реестру объектов интеллектуальной собственности</remarks>
        [LxElementCt("IPObjectRegistryIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt> IPObjectRegistryIdDetails { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.IPObjectRegistryNumTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType CommodityGroupItemDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Характеристика товаров в группе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:CommodityGroupItemDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>249:2-270:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CommodityGroupItemDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class CommodityGroupItemDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные характеристики сведений о товаре</remarks>
        [LxElementCt("CommodityDescriptionDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.GoodsGroupInformationTypeCt CommodityDescriptionDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование места происхождения</remarks>
        [LxElementValue("ProductionPlaceName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ProductionPlaceName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование стандарта (международного, межгосударственного, государтвенного, отраслевого или организации) или технических условий на товар</remarks>
        [LxElementValue("StandardName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String StandardName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUPresentedDocumentsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>ESAD.Представленные документы</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:CUPresentedDocumentsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>271:2-301:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUPresentedDocumentsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class CUPresentedDocumentsTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUESADPresentedDocumentsTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер листа книжки МДП</remarks>
        [LxElementValue("TIRPageNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "2")]
        public System.Numerics.BigInteger? TIRPageNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификационный номер держателя книжки МДП</remarks>
        [LxElementValue("TIRHolderID", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "18")]
        public System.String TIRHolderID { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об информационном ресурсе в информационно-телекоммуникационной сети "Интернет"</remarks>
        [LxElementCt("InformationSourceDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt InformationSourceDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о фактическом представлении документа</remarks>
        [LxElementCt("DocumentPresentingDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt DocumentPresentingDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CustomDocIDType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер таможенного документа</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:CustomDocIDType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>302:2-317:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CustomDocIDType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class CustomDocIDTypeCt : CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер (идентификатор) вносимых изменений и (или) дополнений</remarks>
        [LxElementValue("Code", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "2")]
        public System.String Code { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DeclarantDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о декларанте (заявителе)</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:DeclarantDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>318:2-333:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DeclarantDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class DeclarantDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Свидетельства о включении лица в реестр уполномоченных экономических операторов</remarks>
        [LxElementCt("RegisterDocumentIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt RegisterDocumentIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DisassemComponentType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Компонент товара в несобранном или разобранном виде</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:DisassemComponentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>334:2-369:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DisassemComponentType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class DisassemComponentTypeCt : CustomsLiquidXml.XSD.CatESADCu.ComponentDescriptionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Сборочный номер компонента</remarks>
        [LxElementValue("IDNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String IDNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование компонента</remarks>
        [LxElementValue("ComponentName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String ComponentName { get; set; } = "";

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Служебный порядковый номер компонента</remarks>
        [LxElementValue("ComponentId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "19")]
        public System.Numerics.BigInteger? ComponentId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Сборочный номер родительского компонента</remarks>
        [LxElementValue("ParentIDNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String ParentIDNumber { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак изменения: 1 - добавление компонента, 2 - изменение компонента, 3 - исключение компонента. (Заполняется только при изменении решения по классификации)</remarks>
        [LxElementValue("ChangeAction", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String ChangeAction { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DocumentPresentingDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о фактическом представлении документа</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:DocumentPresentingDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>370:2-416:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DocumentPresentingDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class DocumentPresentingDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак представления документа при подаче таможенной декларации (заявления)</remarks>
        [LxElementValue("DocPresentKindCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String DocPresentKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("PresentedDocumentModeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PresentedDocumentModeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата, до которой должны быть выполнены обязательства по представлению документа</remarks>
        [LxElementValue("DocPresentDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocPresentDate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер декларации на товары, транзитной декларации, заявления о выпуске товаров до подачи декларации на товары или заявления о совершении операций в отношении временно вывезенных транспортных средств международной перевозки, являющихся товарами, помещенными под таможенную процедуру временного ввоза (допуска), к которой (которому) был приложен представленный документ</remarks>
        [LxElementCt("CustomsDocIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt CustomsDocIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер декларации на транспортное средство, к которой был приложен представленный документ</remarks>
        [LxElementCt("DTMDocDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt DTMDocDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Номер книжки МДП, которая использовалась в качестве транзитной декларации и к которой был приложен представленный документ</remarks>
        [LxElementCt("TIRIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt TIRIdDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>регистрационный номер иного документа, к которому был приложен представляемый документ</remarks>
        [LxElementValue("OtherPrecedingDocId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String OtherPrecedingDocId { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>дата выдачи, подписания, утверждения или регистрации иного документа, к которому был приложен представляемый документ</remarks>
        [LxElementValue("OtherPrecedingDocDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? OtherPrecedingDocDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType DTMDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер декларации на транспортное средство</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:DTMDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>417:2-432:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("DTMDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class DTMDocDetailsTypeCt : CustomsLiquidXml.XSD.CatRu.GTDIDTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код вида транспортного средства по классификатору видов транспорта и транспортировки товаров</remarks>
        [LxElementValue("TransportModeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String TransportModeCode { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType GoodsGroupDescriptionType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Описание группы товаров одного наименования с отличающимися от других групп характеристиками</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:GoodsGroupDescriptionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>433:2-454:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsGroupDescriptionType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsGroupDescriptionTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание группы товаров с учетом дополнительных характеристик (качественных, технических, коммерческих), необходимых для классификации товара и для исчисления таможенной стоимости</remarks>
        [LxElementValue("GoodsDescription", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsDescriptions { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код компонента машины в соответствии с ТН ВЭД ЕАЭС</remarks>
        [LxElementValue("RKTNVED", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{4}|[0-9]{6}|[0-9]{8}|[0-9]{10}")]
        public System.String RKTNVED { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.CommodityGroupItemDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CommodityGroupItemDetailsTypeCt" />
        /// </summary>
        /// <remarks>Характеристика товаров в группе</remarks>
        [LxElementCt("CommodityGroupItemDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUDECLcat.CommodityGroupItemDetailsTypeCt> CommodityGroupItemDetails { get; } = new List<CustomsLiquidXml.XSD.RUDECLcat.CommodityGroupItemDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType GoodsLocationDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о месте нахождения товаров</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:GoodsLocationDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>455:2-506:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsLocationDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsLocationDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код места нахождения товаров</remarks>
        [LxElementValue("GoodsLocationCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String GoodsLocationCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа</remarks>
        [LxElementValue("CustomsOfficeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsOfficeCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код государства-члена, в котором находится таможенный орган места нахождения товаров</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование места нахождения товаров (железнодорожной станции, морского (речного) порта)</remarks>
        [LxElementValue("GoodsLocationName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String GoodsLocationName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер зоны таможенного контроля</remarks>
        [LxElementValue("CustomsControlZoneId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String CustomsControlZoneId { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе (разрешение таможенного органа на временное хранение товаров)</remarks>
        [LxElementCt("GoodsLocationDocDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt GoodsLocationDocDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе (свидетельство о включении в реестр уполномоченных экономических операторов, реестры владельцев складов временного хранения, складов хранения собственных товаров, таможенных складов, свободных складов или магазинов беспошлинной торговли)</remarks>
        [LxElementCt("RegisterDocumentIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RegisterDocumentIdDetailsTypeCt RegisterDocumentIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.GoodLocationTransportMeansDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.GoodLocationTransportMeansDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о транспортном средстве в/на котором находятся товары</remarks>
        [LxElementCt("GoodLocationTransportMeansDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.GoodLocationTransportMeansDetailsTypeCt GoodLocationTransportMeansDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес места нахождения товаров</remarks>
        [LxElementCt("UnifiedAddressDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt UnifiedAddressDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType GoodsShipmentSubjectDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о получателе или отправителе товара</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:GoodsShipmentSubjectDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>507:2-532:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("GoodsShipmentSubjectDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class GoodsShipmentSubjectDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt
    {
        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Признак совпадения (несовпадения) сведений со сведениями о декларанте (заявителе): 1 - сведения совпадают</remarks>
        [LxElementValue("EqualIndicator", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? EqualIndicator { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код учреждения обмена (подачи) международных почтовых отправлений</remarks>
        [LxElementValue("ExchangePostOfficeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "6")]
        public System.String ExchangePostOfficeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код особенности сведений о субъекте</remarks>
        [LxElementValue("SubjectAdditionalCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String SubjectAdditionalCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType InformationSourceDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения об информационном источнике или информационном ресурсе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:InformationSourceDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>533:2-554:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("InformationSourceDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class InformationSourceDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование информационного ресурса</remarks>
        [LxElementValue("InformationSourceName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "500")]
        public System.String InformationSourceName { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Ссылка на информационный ресурс</remarks>
        [LxElementValue("DetailsResourceId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "2048")]
        public System.String DetailsResourceId { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата обращения к информационному ресурсу</remarks>
        [LxElementValue("EventDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EventDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PaymentDocumentType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Платежный документ</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PaymentDocumentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>555:2-580:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PaymentDocumentType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PaymentDocumentTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида документа</remarks>
        [LxElementValue("CustomsDocumentCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String CustomsDocumentCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ИНН</remarks>
        [LxElementValue("INN", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "10", MaxLength = "12")]
        public System.String INN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор физического лица</remarks>
        [LxElementValue("PersonId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String PersonId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PaymentGuaranteeDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о предоставленном обеспечении уплаты таможенных пошлин, налогов</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PaymentGuaranteeDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>581:2-612:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PaymentGuaranteeDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PaymentGuaranteeDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код способа обеспечения уплаты таможенных пошлин, налогов</remarks>
        [LxElementValue("PaymentGuaranteeMethodCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String PaymentGuaranteeMethodCode { get; set; } = "";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt" />
        /// </summary>
        /// <remarks>Сумма обеспечения</remarks>
        [LxElementCt("GuaranteeAmount", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt GuaranteeAmount { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.AmountTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, подтверждающем обеспечение уплаты таможенных пошлин и налогов</remarks>
        [LxElementCt("GuaranteeDocDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt GuaranteeDocDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ИНН юридического или физического лица</remarks>
        [LxElementValue("INN", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "10", MaxLength = "12")]
        public System.String INN { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор банка, используемый в платежных документах (платежное поручение, аккредитив)</remarks>
        [LxElementValue("BankId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{9}|[A-Z]{6}[A-Z0-9]{2}|[A-Z]{6}[A-Z0-9]{5}")]
        public System.String BankId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PlaceDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Место</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PlaceDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>613:2-629:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PlaceDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PlaceDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование (название) места (географического пункта)</remarks>
        [LxElementValue("PlaceName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "120")]
        public System.String PlaceName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес места</remarks>
        [LxElementCt("AddressDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt AddressDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PowerOfAttorneyDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Документ, удостоверяющий полномочия</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PowerOfAttorneyDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>630:2-645:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PowerOfAttorneyDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PowerOfAttorneyDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы, присвоенные документу (сведениям) при размещении в хранилище электронных документов</remarks>
        [LxElementCt("DocArchIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt DocArchIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PrecedingDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о предшествующем документе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PrecedingDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>646:2-707:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PrecedingDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PrecedingDocDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Идентификатор записи о пердшествующем документе</remarks>
        [LxElementValue("LineId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String LineId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида предшествующего документа в соответствии с классификатором видов документов</remarks>
        [LxElementValue("PrecedingDocumentModeCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PrecedingDocumentModeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование предшествующего документа</remarks>
        [LxElementValue("PrecedingDocumentName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String PrecedingDocumentName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер декларации на товары, транзитной декларации, заявления о выпуске товаров до подачи декларации на товары или заявления о совершении операций в отношении временно вывезенных транспортных средств международной перевозки, являющихся товарами, помещенными под таможенную процедуру временного ввоза (допуска)</remarks>
        [LxElementCt("CustomsDocIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.CustomDocIDTypeCt CustomsDocIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер декларации на транспортное средство</remarks>
        [LxElementCt("DTMDocDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.DTMDocDetailsTypeCt DTMDocDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер предварительной информации</remarks>
        [LxElementValue("PIDocumentNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String PIDocumentNumber { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер книжки МДП</remarks>
        [LxElementCt("TIRIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.TIRIdDetailsTypeCt TIRIdDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Регистрационный номер иного предшествующего документа</remarks>
        [LxElementValue("OtherPrDocumentNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String OtherPrDocumentNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата регистрации иного предшествующего документа</remarks>
        [LxElementValue("OtherPrDocumentDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? OtherPrDocumentDate { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Порядковый номер товара в предшествующем документе</remarks>
        [LxElementValue("PrecedingDocumentGoodsNumeric", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? PrecedingDocumentGoodsNumeric { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.PrecedingGoodsDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PrecedingGoodsDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о товаре, заявленные в предшествующем документе</remarks>
        [LxElementCt("PrecedingGoodsDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.PrecedingGoodsDetailsTypeCt PrecedingGoodsDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PrecedingDocumentCustomsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационные данные таможенного предшествующего документа</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PrecedingDocumentCustomsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>708:2-729:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PrecedingDocumentCustomsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PrecedingDocumentCustomsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенного органа предшествующего документа</remarks>
        [LxElementValue("PrecedingDocumentCustomsCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String PrecedingDocumentCustomsCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Предшествующий документ - дата</remarks>
        [LxElementValue("PrecedingDocumentDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? PrecedingDocumentDate { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Предшествующий документ - регистрационный номер документа / номер документа при транзите</remarks>
        [LxElementValue("PrecedingDocumentNumber", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String PrecedingDocumentNumber { get; set; } = "";

    }

    /// <summary>A class representing the root XSD complexType PrecedingDocumentOtherType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационные данные иного предшествующего документа</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PrecedingDocumentOtherType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>730:2-746:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PrecedingDocumentOtherType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PrecedingDocumentOtherTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Цифровое или буквенно-цифровое обозначение, присвоенное документу при его регистрации</remarks>
        [LxElementValue("DocId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String DocId { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата регистрации иного документа</remarks>
        [LxElementValue("DocCreationDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocCreationDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PrecedingGoodsDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о товаре, заявленном в предшествующем документе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PrecedingGoodsDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>747:2-778:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PrecedingGoodsDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PrecedingGoodsDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код ТН ВЭД ЕАЭС, указанный в предшествующем документе</remarks>
        [LxElementValue("PrcDocGoodsTNVEDCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[0-9]{4}|[0-9]{6}|[0-9]{8}|[0-9]{10}")]
        public System.String PrcDocGoodsTNVEDCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Масса нетто товара, использованного при изготовлении или вошедшего в состав декларируемого товара</remarks>
        [LxElementValue("NetWeightQuantity", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeightQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Масса товара нетто, указанная в предшествующем таможенном документе</remarks>
        [LxElementValue("NetWeight", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal? NetWeight { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Таможенная стоимость товара, указанная в предшествующем документе</remarks>
        [LxElementValue("CustomsCost", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? CustomsCost { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара, использованного при изготовлении или вошедшего в состав декларируемого товара</remarks>
        [LxElementCt("SupplementaryGoodsQuantity", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> SupplementaryGoodsQuantities { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType PresentedDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о представленном документе</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:PresentedDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>779:2-794:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PresentedDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class PresentedDocDetailsTypeCt : CustomsLiquidXml.XSD.RUDECLcat.BasePresentedDocDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о фактическом представлении документа</remarks>
        [LxElementCt("DocumentPresentingDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.DocumentPresentingDetailsTypeCt DocumentPresentingDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ProcessingGoodsDeclarationType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Заявление на переработку товаров</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:ProcessingGoodsDeclarationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>795:2-846:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ProcessingGoodsDeclarationType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class ProcessingGoodsDeclarationTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Норма выхода продуктов переработки</remarks>
        [LxElementValue("RateOutputGoods", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> RateOutputGoods { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt" />
        /// </summary>
        /// <remarks>Сведения о предыдущем документе об условиях переработки</remarks>
        [LxElementCt("ProcessingDoc", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.DocBaseTypeCt ProcessingDoc { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Способы идентификации ввезенных/вывезенных товаров в продуктах переработки</remarks>
        [LxElementValue("GoodsIdentificationMethod", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> GoodsIdentificationMethods { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.PlaceDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PlaceDetailsTypeCt" />
        /// </summary>
        /// <remarks>Место совершения операций по переработке товаров</remarks>
        [LxElementCt("ProcessingPlaceDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUDECLcat.PlaceDetailsTypeCt> ProcessingPlaceDetails { get; } = new List<CustomsLiquidXml.XSD.RUDECLcat.PlaceDetailsTypeCt>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Сведения о замене иностранных товаров эквивалентными товарами</remarks>
        [LxElementValue("Substitute", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> Substitutes { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsBankTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.DeclarantDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUFinancialAdjustingResponsiblePersonTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUCarrierTypeCt" />
        /// </summary>
        /// <remarks>Наименование лица, осуществляющего операции по переработке товаров</remarks>
        [LxElementCt("Organization", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt Organization { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />
        /// </summary>
        /// <remarks>Продукт переработки</remarks>
        [LxElementCt("ProcessingProduct", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt ProcessingProduct { get; set; } = new CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />
        /// </summary>
        /// <remarks>Отходы переработки</remarks>
        [LxElementCt("WasteProducts", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt> WasteProducts { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt" />
        /// </summary>
        /// <remarks>Остатки</remarks>
        [LxElementCt("Heels", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt> Heels { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ProcessingGoodsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType RegisterDocumentDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе, подтверждающем включение в реестр</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:RegisterDocumentDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>847:2-878:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegisterDocumentDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class RegisterDocumentDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Регистрационный номер лица, присвоенный ему при включении в реестр, или регистрационный номер документа о включении лица в реестр</remarks>
        [LxElementValue("RegistrationNumberIdentifier", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String RegistrationNumberIdentifier { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата подписания, утверждения или регистрации документа</remarks>
        [LxElementValue("DocCreationDate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocCreationDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Тип документа, подтверждающего включение юридического лица в реестр</remarks>
        [LxElementValue("RegisterDocumentCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String RegisterDocumentCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодированное обозначение признака перерегистрации</remarks>
        [LxElementValue("ReregistrationCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String ReregistrationCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код страны</remarks>
        [LxElementValue("CountryCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RegisterDocumentIdDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Компоненты, представляющие сведения о номере свидетельства о включении юридического лица в реестр уполномоченных экономических операторов</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:RegisterDocumentIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>879:2-905:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegisterDocumentIdDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class RegisterDocumentIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение страны</remarks>
        [LxElementValue("CountryA2Code", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CountryA2Code { get; set; }

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Регистрационный номер лица, присвоенный ему при включении в реестр, или регистрационный номер документа о включении лица в реестр</remarks>
        [LxElementValue("RegistrationNumberId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "25")]
        public System.String RegistrationNumberId { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение признака перерегистрации документа</remarks>
        [LxElementValue("ReregistrationCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String ReregistrationCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код типа свидетельства уполномоченного экономического оператора</remarks>
        [LxElementValue("AEORegistryKindCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String AEORegistryKindCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RepresentativeContractDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о договоре таможенного представителя с участником ВЭД</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:RepresentativeContractDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>906:2-921:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RepresentativeContractDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class RepresentativeContractDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.DocBaseV2TypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы, присвоенные документу (сведениям) при размещении в хранилище электронных документов</remarks>
        [LxElementCt("DocArchIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt DocArchIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SignatoryPersonDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о физическом лице, заполнившем (подписавшем) таможенный документ</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:SignatoryPersonDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>922:2-948:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatoryPersonDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class SignatoryPersonDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.SigningDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.SigningDetailsTypeCt" />
        /// </summary>
        /// <remarks>Cведения о должностном лице, подписавшем документ</remarks>
        [LxElementCt("SigningDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.SigningDetailsTypeCt SigningDetails { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.SigningDetailsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о документе, удостоверяющем личность лица, заполнившего (подписавшего) таможенный документ</remarks>
        [LxElementCt("SignatoryPersonIdentityDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonIdentityDetailsTypeCt SignatoryPersonIdentityDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер квалификационного аттестата специалиста по таможенному оформлению</remarks>
        [LxElementValue("QualificationCertificate", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "6")]
        public System.String QualificationCertificate { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt" />
        /// </summary>
        /// <remarks>Документ, удостоверяющий полномочия</remarks>
        [LxElementCt("PowerOfAttorneyDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.PowerOfAttorneyDetailsTypeCt PowerOfAttorneyDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SignatoryPersonIdentityDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе, удостоверяющем личность лица, заполнившего (подписавшего) таможенный документ</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:SignatoryPersonIdentityDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>949:2-964:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatoryPersonIdentityDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class SignatoryPersonIdentityDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.RUIdentityCardTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы, присвоенные документу (сведениям) при размещении в хранилище электронных документов</remarks>
        [LxElementCt("DocArchIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt DocArchIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SignatoryRepresentativeDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о таможенном представителе, заполнившем (подписавшем) таможенный документ</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:SignatoryRepresentativeDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>965:2-981:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignatoryRepresentativeDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class SignatoryRepresentativeDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.BrokerRegistryDocDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.BrokerRegistryDocDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о включении лица в реестр таможенных представителей</remarks>
        [LxElementCt("BrokerRegistryDocDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.BrokerRegistryDocDetailsTypeCt BrokerRegistryDocDetails { get; set; } = new CustomsLiquidXml.XSD.RUDECLcat.BrokerRegistryDocDetailsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt" />
        /// </summary>
        /// <remarks>Договор таможенного представителя с декларантом (заявителем)</remarks>
        [LxElementCt("RepresentativeContractDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt RepresentativeContractDetails { get; set; } = new CustomsLiquidXml.XSD.RUDECLcat.RepresentativeContractDetailsTypeCt();

    }

    /// <summary>A class representing the root XSD complexType SignCertifPersonType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения из сертификата электронной подписи</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:SignCertifPersonType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>982:2-1012:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SignCertifPersonType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class SignCertifPersonTypeCt : CustomsLiquidXml.XSD.CatRu.PersonBaseTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы организации / лица</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер СНИЛС</remarks>
        [LxElementValue("SNILS", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String SNILS { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование организации</remarks>
        [LxElementValue("OrganizationName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String OrganizationName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Лицо, на которое выдан сертификат (общее имя)</remarks>
        [LxElementValue("SertifName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String SertifName { get; set; }

    }

    /// <summary>A class representing the root XSD complexType SimplePresentedDocDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Сведения о документе и (или) источнике информации</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:SimplePresentedDocDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1013:2-1058:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("SimplePresentedDocDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class SimplePresentedDocDetailsTypeCt : CustomsLiquidXml.XSD.RUScatRu.DocBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение вида документа</remarks>
        [LxElementValue("DocKindCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocKindCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Полное наименование органа государственной власти государства-члена либо уполномоченной им организации, выдавшей документ</remarks>
        [LxElementValue("AuthorityName", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "300")]
        public System.String AuthorityName { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Строка символов, идентифицирующая государственный или межгосударственный орган (организацию), выдавший или утвердивший документ</remarks>
        [LxElementValue("AuthorityId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String AuthorityId { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об информационном источнике или информационном ресурсе</remarks>
        [LxElementCt("InformationSourceDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.InformationSourceDetailsTypeCt InformationSourceDetails { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор, используемый для целей однозначной ссылки на запись, или порядковый номер записи</remarks>
        [LxElementValue("LineId", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "40")]
        public System.String LineId { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кодовое обозначение электронного документа (сведений) в соответствии с реестром структур электронных документов и сведений</remarks>
        [LxElementValue("EDocCode", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "10")]
        public System.String EDocCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.RFPresentedDocIDTypeCt" />
        /// </summary>
        /// <remarks>Идентификаторы, присвоенные документу (сведениям) при размещении в хранилище электронных документов</remarks>
        [LxElementCt("DocArchIdDetails", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.RFBasePresentedDocIDTypeCt DocArchIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TDGuaranteeType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Гарантия для ТД</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:TDGuaranteeType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1059:2-1074:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TDGuaranteeType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class TDGuaranteeTypeCt : CustomsLiquidXml.XSD.CatESADCu.TDGuaranteeTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес гаранта</remarks>
        [LxElementCt("GuaranteeAddress", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt GuaranteeAddress { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TIRIdDetailsType@urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0</summary>
    /// <remarks>Регистрационный номер книжки МДП</remarks>
    /// <XsdPath>schema:RUDeclCommonAggregateTy...xsd/complexType:TIRIdDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\RUDeclCommonAggregateTypesCust.xsd</XsdFile>
    /// <XsdLocation>1075:2-1091:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TIRIdDetailsType", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0")]
    public partial class TIRIdDetailsTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Серия книжки МДП</remarks>
        [LxElementValue("TIRSeries", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String TIRSeries { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Номер книжки МДП</remarks>
        [LxElementValue("TIRID", "urn:customs.ru:RUDeclCommonAggregateTypesCust:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "8")]
        public System.String TIRID { get; set; } = "";

    }

    #endregion

}

namespace CustomsLiquidXml.XSD.ESADoutCU
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType AuthoriziedOperatorDetailsType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения об уполномоченном экономическом операторе</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:AuthoriziedOperatorDetailsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>157:2-173:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("AuthoriziedOperatorDetailsType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class AuthoriziedOperatorDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Номер свидетельства о включении в реестр уполномоченных экономических операторов</remarks>
        [LxElementCt("OperatorRegistryDoc", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt OperatorRegistryDoc { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес помещений, открытых площадок или иных территорий уполномоченного экономического оператора</remarks>
        [LxElementCt("OperatorAddress", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt OperatorAddress { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CustomsPaymentType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения об уплате. Гр. В</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:CustomsPaymentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>200:2-252:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CustomsPaymentType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class CustomsPaymentTypeCt : CustomsLiquidXml.XSD.CatESADCu.ESADout_CUCustomsPaymentTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Способ уплаты в соответствии с классификатором способов уплаты таможенных и иных платежей, взимание которых возложено на таможенные органы</remarks>
        [LxElementValue("PaymentWayCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String PaymentWayCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt" />
        /// </summary>
        /// <remarks>Платежный документ</remarks>
        [LxElementCt("PaymentDocument", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.PaymentDocumentTypeCt PaymentDocument { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Российской Федерации</remarks>
        [LxElementCt("RFOrganizationFeatures", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RFOrganizationFeaturesTypeCt RFOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Казахстан</remarks>
        [LxElementCt("RKOrganizationFeatures", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RKOrganizationFeaturesTypeCt RKOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Беларусь</remarks>
        [LxElementCt("RBOrganizationFeatures", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RBOrganizationFeaturesTypeCt RBOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Республики Армения</remarks>
        [LxElementCt("RAOrganizationFeatures", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.RAOrganizationFeaturesTypeCt RAOrganizationFeatures { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt" />
        /// </summary>
        /// <remarks>Сведения об организации. Особенности Кыргызской Республики</remarks>
        [LxElementCt("KGOrganizationFeatures", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.KGOrganizationFeaturesTypeCt KGOrganizationFeatures { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Уникальный идентификатор физического лица</remarks>
        [LxElementValue("PersonId", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "20")]
        public System.String PersonId { get; set; }

    }

    /// <summary>A class representing the root XSD complexType CUWarehousePlaceType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения о местонахождении товаров: разрешение таможенного органа на временное хранение товаров, склад временного хранения, таможенный склад, свободный склад, магазин беспошлинной торговли, помещение, открытые площадки и иные территории уполномоченного экономического оператора, склад хранения собственных товаров, склад получателя товаров</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:CUWarehousePlaceType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>174:2-199:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("CUWarehousePlaceType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class CUWarehousePlaceTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("PresentedDocumentModeCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String PresentedDocumentModeCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата начала срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocStartDate", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocStartDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания срока, в течение которого документ имеет силу</remarks>
        [LxElementValue("DocValidityDate", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DocValidityDate { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUBorderTransportType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Транспортные средства на границе / внутри страны</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUBorderTransportType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>253:2-283:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUBorderTransportType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUBorderTransportTypeCt : CustomsLiquidXml.XSD.CatRu.CUTransportMeansTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество транспортных средств</remarks>
        [LxElementValue("TransportMeansQuantity", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger? TransportMeansQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Способ транспортировки товаров при перемещении по линиям электропередачи или трубопроводным транспортом: 1 - газопровод; 2 - нефтепровод; 3 - нефтепродуктопровод; 4 - линии электропередачи</remarks>
        [LxElementValue("MethodTransport", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? MethodTransport { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование объекта, на котором установлены приборы учета товаров, перемещаемых по линиям электропередачи или трубопроводным транспортом</remarks>
        [LxElementValue("NameObject", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> NameObjects { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Описание транспортного средства</remarks>
        [LxElementCt("TransportMeans", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt> TransportMeans { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUCarrierType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения о перевозчике</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUCarrierType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>284:2-299:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUCarrierType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUCarrierTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectDetailsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.CarrierRepresentativeDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.CarrierRepresentativeDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о лице, являющимся сотрудником или уполномоченным представителем перевозчика</remarks>
        [LxElementCt("ESADout_CUDriverInformation", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUScatRu.CarrierRepresentativeDetailsTypeCt> ESADout_CUDriverInformations { get; } = new List<CustomsLiquidXml.XSD.RUScatRu.CarrierRepresentativeDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUConsigmentType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения о перевозке товаров. Гр. 15, 15а, 17,17а, 18, 19, 21, 25, 26, 29 - ДТ/ Гр. 15, 17, 18, 19, 21, 25, 26, 29 , 53, 55 - ТД</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUConsigmentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>300:2-345:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUConsigmentType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUConsigmentTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUConsigmentTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUDepartureArrivalTransportTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUDepartureArrivalTransportTypeCt" />
        /// </summary>
        /// <remarks>Транспортные средства при прибытии/убытии. Гр. 18, 26</remarks>
        [LxElementCt("ESADout_CUDepartureArrivalTransport", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUDepartureArrivalTransportTypeCt ESADout_CUDepartureArrivalTransport { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUBorderTransportTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUBorderTransportTypeCt" />
        /// </summary>
        /// <remarks>Транспортные средства на границе. Гр. 21, 25 ДТ</remarks>
        [LxElementCt("ESADout_CUBorderTransport", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUBorderTransportTypeCt ESADout_CUBorderTransport { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADReloadingInfoTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADReloadingInfoTypeCt" />
        /// </summary>
        /// <remarks>Информация о перегрузке товаров. Гр. 55 ТД</remarks>
        [LxElementCt("ESADout_CUReloadingInfo", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADReloadingInfoTypeCt> ESADout_CUReloadingInfos { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADReloadingInfoTypeCt>();

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата ожидаемого прибытия товаров и транспортных средств в пограничный пункт пропуска. ТД</remarks>
        [LxElementValue("DateExpectedArrival", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? DateExpectedArrival { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время ожидаемого прибытия товаров и транспортных средств в пограничный пункт пропуска. ТД</remarks>
        [LxElementValue("TimeExpectedArrival", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? TimeExpectedArrival { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган (пограничный пункт пропуска), в который ожидается прибытие товаров и транспортных средств</remarks>
        [LxElementCt("PPBorderCustoms", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt PPBorderCustoms { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.TDDeliveryPlaceTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.TDDeliveryPlaceTypeCt" />
        /// </summary>
        /// <remarks>Место назначения при транзите. гр 53 ТД</remarks>
        [LxElementCt("TDDeliveryPlace", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.TDDeliveryPlaceTypeCt TDDeliveryPlace { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUDepartureArrivalTransportType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Транспортные средства при отправлении/прибытии. Гр. 18, 26 ДТ</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUDepartureArrivalTransportType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>346:2-376:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUDepartureArrivalTransportType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUDepartureArrivalTransportTypeCt : CustomsLiquidXml.XSD.CatRu.CUTransportMeansTypeCt
    {
        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество транспортных средств</remarks>
        [LxElementValue("TransportMeansQuantity", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "1", TotalDigits = "5")]
        public System.Numerics.BigInteger? TransportMeansQuantity { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Способ транспортировки товаров при перемещении по линиям электропередачи или трубопроводным транспортом: 1 - газопровод; 2 - нефтепровод; 3 - нефтепродуктопровод; 4 - линии электропередачи</remarks>
        [LxElementValue("MethodTransport", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal? MethodTransport { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Наименование объекта, на котором установлены приборы учета товаров, перемещаемых по линиям электропередачи или трубопроводным транспортом</remarks>
        [LxElementValue("NameObject", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> NameObjects { get; } = new List<System.String>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Описание транспортного средства</remarks>
        [LxElementCt("TransportMeans", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt> TransportMeans { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.TransportMeansRegistrationIdDetailsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUFinancialAdjustingResponsiblePersonType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Лицо ответственное за финансовое урегулирование</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUFinancialAdjustingResponsiblePersonType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>377:2-392:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUFinancialAdjustingResponsiblePersonType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUFinancialAdjustingResponsiblePersonTypeCt : CustomsLiquidXml.XSD.RUScatRu.SubjectBranchDetailsTypeCt
    {
        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Признак совпадения сведений со сведениями, заявляемыми в гр. 14 ДТ. 1 - сведения совпадают</remarks>
        [LxElementValue("DeclarantEqualFlag", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? DeclarantEqualFlag { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUGoodsLocationType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Местонахождение товаров. Гр. 30</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUGoodsLocationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>393:2-444:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUGoodsLocationType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUGoodsLocationTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код места нахождения товаров в соответствии c классификатором мест нахождения товаров</remarks>
        [LxElementValue("InformationTypeCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String InformationTypeCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код таможенного органа в соответствии с классификаторами таможенных органов, применяемыми в государствах - членах Евразийского экономического союза</remarks>
        [LxElementValue("CustomsOffice", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[0-9]{2}|[0-9]{5}|[0-9]{8}")]
        public System.String CustomsOffice { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны таможенного органа</remarks>
        [LxElementValue("CustomsCountryCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String CustomsCountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Наименование железнодорожной станции/морского (речного) порта</remarks>
        [LxElementValue("LocationName", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String LocationName { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUGoodsLocationPlaceTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUGoodsLocationPlaceTypeCt" />
        /// </summary>
        /// <remarks>Сведения о местонахождении товаров</remarks>
        [LxElementCt("GoodsLocationPlace", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUGoodsLocationPlaceTypeCt GoodsLocationPlace { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt" />
        /// </summary>
        /// <remarks>Разрешение таможенного органа на : временное хранение товаров, склад временного хранения, таможенный склад, свободный склад, магазин беспошлинной торговли, помещение, открытые площадки и иные территории уполномоченного экономического оператора, склад хранения собственных товаров</remarks>
        [LxElementCt("GoodsLocationWarehouse", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.CUWarehousePlaceTypeCt GoodsLocationWarehouse { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Свидетельство о включении в реестр уполномоченных экономических операторов, свидетельство о включении в реестр владельцев складов временного хранения, документ (свидетельство), удостоверяющий регистрацию лица в качестве резидента (участника) свободной (специальной, особой) экономической зоны</remarks>
        [LxElementCt("RegisterDocumentIdDetails", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.AEORegistryIdDetailsTypeCt RegisterDocumentIdDetails { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUTransportTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUTransportTypeCt" />
        /// </summary>
        /// <remarks>Сведения о местонахождении товаров - транспортное средство</remarks>
        [LxElementCt("Transport", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.CUTransportTypeCt Transport { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt" />
        /// </summary>
        /// <remarks>Адрес местонахождения товаров</remarks>
        [LxElementCt("Address", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.RUAddressTypeCt Address { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUGoodsShipmentType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения о товарной партии</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUGoodsShipmentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>445:2-515:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUGoodsShipmentType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUGoodsShipmentTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUESADGoodsShipmentTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об отправителе товаров</remarks>
        [LxElementCt("ESADout_CUConsignor", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt ESADout_CUConsignor { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о получателе товаров</remarks>
        [LxElementCt("ESADout_CUConsignee", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.GoodsShipmentSubjectDetailsTypeCt ESADout_CUConsignee { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUFinancialAdjustingResponsiblePersonTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUFinancialAdjustingResponsiblePersonTypeCt" />
        /// </summary>
        /// <remarks>Лицо ответственное за финансовое урегулирование</remarks>
        [LxElementCt("ESADout_CUFinancialAdjustingResponsiblePerson", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUFinancialAdjustingResponsiblePersonTypeCt ESADout_CUFinancialAdjustingResponsiblePerson { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о декларанте товаров</remarks>
        [LxElementCt("ESADout_CUDeclarant", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt ESADout_CUDeclarant { get; set; } = new CustomsLiquidXml.XSD.RUDECLcat.AEODeclarantDetailsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUCarrierTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUCarrierTypeCt" />
        /// </summary>
        /// <remarks>Сведения о перевозчике гр. 50 ТД</remarks>
        [LxElementCt("ESADout_CUCarrier", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUCarrierTypeCt ESADout_CUCarrier { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsLocationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsLocationTypeCt" />
        /// </summary>
        /// <remarks>Местонахождение товаров. Гр. 30 ДТ</remarks>
        [LxElementCt("ESADout_CUGoodsLocation", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsLocationTypeCt> ESADout_CUGoodsLocations { get; } = new List<CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsLocationTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUConsigmentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUConsigmentTypeCt" />
        /// </summary>
        /// <remarks>Сведения о перевозке товаров. Гр. 15, 15а, 17,17а, 18, 19, 21, 25, 26, 29 - ДТ/ Гр. 15, 17, 18, 19, 21, 25, 26, 29 , 53, 55 - ТД</remarks>
        [LxElementCt("ESADout_CUConsigment", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUConsigmentTypeCt ESADout_CUConsigment { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUMainContractTermsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUMainContractTermsTypeCt" />
        /// </summary>
        /// <remarks>Условия сделки Гр. 11, 20, 22, 23, 24 ДТ</remarks>
        [LxElementCt("ESADout_CUMainContractTerms", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUMainContractTermsTypeCt ESADout_CUMainContractTerms { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsTypeCt" />
        /// </summary>
        /// <remarks>Товарная часть Гр. 31-47</remarks>
        [LxElementCt("ESADout_CUGoods", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsTypeCt> ESADout_CUGoodss { get; } = new List<CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUPaymentsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUPaymentsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об уплачиваемых платежах, платежных поручениях, отсрочке платежей. Гр. 48, В</remarks>
        [LxElementCt("ESADout_CUPayments", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUPaymentsTypeCt ESADout_CUPayments { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUGuaranteeTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUGuaranteeTypeCt" />
        /// </summary>
        /// <remarks>Гарантия.Гр 52 в ДТ</remarks>
        [LxElementCt("Guarantee", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CUGuaranteeTypeCt> Guarantees { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CUGuaranteeTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.TDGuaranteeTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.TDGuaranteeTypeCt" />
        /// </summary>
        /// <remarks>Гарантия для ТД</remarks>
        [LxElementCt("TDGuarantee", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUDECLcat.TDGuaranteeTypeCt> TDGuarantees { get; } = new List<CustomsLiquidXml.XSD.RUDECLcat.TDGuaranteeTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUGoodsType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Товарная часть. Гр. 31-47</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUGoodsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>516:2-631:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUGoodsType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUGoodsTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUESADGoodsItemTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код языка описания товара</remarks>
        [LxElementValue("LanguageGoods", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "[A-Z]{2}")]
        public System.String LanguageGoods { get; set; }

        /// <summary>A nullable <see cref="System.Boolean" />, Optional : null when not set</summary>
        /// <remarks>Признак продукции военного назначения. true - да, false - нет. Гр.31 ТД</remarks>
        [LxElementValue("MilitaryProducts", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdBoolean, MinOccurs = 0, MaxOccurs = 1)]
        public System.Boolean? MilitaryProducts { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код валюты стоимости товара (заполняется для ТД)</remarks>
        [LxElementValue("CurrencyCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String CurrencyCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt" />
        /// </summary>
        /// <remarks>Представленные документы. Гр. 44</remarks>
        [LxElementCt("ESADout_CUPresentedDocument", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt> ESADout_CUPresentedDocuments { get; } = new List<CustomsLiquidXml.XSD.RUDECLcat.CUPresentedDocumentsTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPrecedingDocumentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUPrecedingDocumentTypeCt" />
        /// </summary>
        /// <remarks>Предшествующие документы. Гр. 40</remarks>
        [LxElementCt("ESADout_CUPrecedingDocument", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CUPrecedingDocumentTypeCt> ESADout_CUPrecedingDocuments { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CUPrecedingDocumentTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUCustomsPaymentCalculationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUCustomsPaymentCalculationTypeCt" />
        /// </summary>
        /// <remarks>Исчисление таможенных платежей</remarks>
        [LxElementCt("ESADout_CUCustomsPaymentCalculation", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CUCustomsPaymentCalculationTypeCt> ESADout_CUCustomsPaymentCalculations { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CUCustomsPaymentCalculationTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.ProcessingGoodsDeclarationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.ProcessingGoodsDeclarationTypeCt" />
        /// </summary>
        /// <remarks>Сведения, указываемые в случае, если ДТ используется в качестве заявления на получение разрешения на переработку товаров (элемент 6 гр 31, гр 44)</remarks>
        [LxElementCt("ESADout_CUCustomsConditions", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.ProcessingGoodsDeclarationTypeCt ESADout_CUCustomsConditions { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара в дополнительной единице измерения. Гр.41</remarks>
        [LxElementCt("SupplementaryGoodsQuantity", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt SupplementaryGoodsQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара в единице измерения, отличной от основной и дополнительной (элемент 1 Гр.31)</remarks>
        [LxElementCt("SupplementaryGoodsQuantity1", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt> SupplementaryGoodsQuantity1s { get; } = new List<CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADGoodsPackagingTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADGoodsPackagingTypeCt" />
        /// </summary>
        /// <remarks>Сведения о грузовых местах, поддонах и упаковке товаров</remarks>
        [LxElementCt("ESADGoodsPackaging", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADGoodsPackagingTypeCt ESADGoodsPackaging { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADGoodsQuotaTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADGoodsQuotaTypeCt" />
        /// </summary>
        /// <remarks>Квота.Гр 39 в ДТ</remarks>
        [LxElementCt("ESADGoodsQuota", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADGoodsQuotaTypeCt ESADGoodsQuota { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADContainerTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADContainerTypeCt" />
        /// </summary>
        /// <remarks>Сведения о контейнерах (элемент 3 Гр 31)</remarks>
        [LxElementCt("ESADContainer", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADContainerTypeCt> ESADContainers { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADContainerTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADCustomsProcedureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADCustomsProcedureTypeCt" />
        /// </summary>
        /// <remarks>Процедура.Гр 37</remarks>
        [LxElementCt("ESADCustomsProcedure", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.ESADCustomsProcedureTypeCt ESADCustomsProcedure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.ESADExciseTypeCt" />
        /// </summary>
        /// <remarks>Сведения об акцизных или специальных марках (элемент 4 гр 31)</remarks>
        [LxElementCt("ESADExcise", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.ESADExciseTypeCt> ESADExcises { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.ESADExciseTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt" />
        /// </summary>
        /// <remarks>Сведения о количестве принятой электроэнергии за отчетный период (элемент 9 Гр 31)</remarks>
        [LxElementCt("ElectricalEnergReceived", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt> ElectricalEnergReceiveds { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt" />
        /// </summary>
        /// <remarks>Сведения о количестве переданной электроэнергии за отчетный период (элемент 9 Гр 31)</remarks>
        [LxElementCt("ElectricalEnergGiven", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt> ElectricalEnergGivens { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CU_ElectricalEnergyTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.AutomobileTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.AutomobileTypeCt" />
        /// </summary>
        /// <remarks>Сведения об автомобилях. Гр. 31</remarks>
        [LxElementCt("GoodsAutomobile", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.AutomobileTypeCt> GoodsAutomobiles { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.AutomobileTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Количество товара помещенного под процедуру переработки и свободную таможенную зону для РБ / Cведения о количестве товара, предназначенные для включения в реестр автоматизированного контроля сроков действия таможенных процедур</remarks>
        [LxElementCt("RBSupplementaryGoodsQuantity", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt RBSupplementaryGoodsQuantity { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Общая масса брутто товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде</remarks>
        [LxElementCt("TotalGrossMassMeasure", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt TotalGrossMassMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt" />
        /// </summary>
        /// <remarks>Общая масса нетто товара, перемещаемого через таможенную границу Евразийского экономического союза в несобранном или разобранном виде, в том числе некомплектном или незавершенном виде</remarks>
        [LxElementCt("TotalNetMassMeasure", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.SupplementaryQuantityTypeCt TotalNetMassMeasure { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.InvestmentGoodsIdDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.InvestmentGoodsIdDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о регистрационном номере товара (технологического оборудования, комплектующих и запасных частей к нему, сырья и материалов), указанном в перечне товаров, ввозимых для реализации инвестиционного проекта</remarks>
        [LxElementCt("InvestmentGoodsIdDetails", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatESADCu.InvestmentGoodsIdDetailsTypeCt InvestmentGoodsIdDetails { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUMainContractTermsType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Условия сделки Гр. 11, 20, 22, 23, 24 ДТ</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUMainContractTermsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>632:2-639:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUMainContractTermsType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUMainContractTermsTypeCt : CustomsLiquidXml.XSD.CatESADCu.CUESADMainContractTermsTypeCt
    {
    }

    /// <summary>A class representing the root XSD complexType ESADout_CUPaymentsType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Сведения об уплачиваемых платежах, платежных поручениях, отсрочке платежей. Гр. 48, В</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUPaymentsType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>640:2-656:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUPaymentsType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUPaymentsTypeCt
    {
        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.CustomsPaymentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.CustomsPaymentTypeCt" />
        /// </summary>
        /// <remarks>Сведения об уплате. Гр. В</remarks>
        [LxElementCt("ESADout_CUCustomsPayment", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.ESADoutCU.CustomsPaymentTypeCt> ESADout_CUCustomsPayments { get; } = new List<CustomsLiquidXml.XSD.ESADoutCU.CustomsPaymentTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatESADCu.CUDelayPaymentsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatESADCu.CUDelayPaymentsTypeCt" />
        /// </summary>
        /// <remarks>Отсрочка платежей гр.48</remarks>
        [LxElementCt("CUDelayPayments", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatESADCu.CUDelayPaymentsTypeCt> CUDelayPayments { get; } = new List<CustomsLiquidXml.XSD.CatESADCu.CUDelayPaymentsTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ESADout_CUType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>«Электронная копия декларации на товары и транзитной декларации»</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>18:2-153:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("ESADout_CUType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class ESADout_CUTypeCt : CustomsLiquidXml.XSD.CatRu.BaseDocTypeCt
    {
        /// <summary>The value for the attribute DocumentModeID</summary>
        /// <remarks>Идентификатор вида документа. (Код документа в Альбоме форматов для РФ)</remarks>
        /// <XsdPath>schema:ESADout_CU.xsd/complexType:ESADout_CUType/attribute:DocumentModeID</XsdPath>
        /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
        /// <XsdLocation>146:5-150:20</XsdLocation>
        [LxAttribute("DocumentModeID", "", LxValueType.Value, XsdType.XsdToken, Required = true, MinLength = "1", MaxLength = "30")]
        public System.String DocumentModeID { get; set; } = "1006107E";

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUScatRu.EECEDocHeaderAddInfoTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUScatRu.EECEDocHeaderAddInfoTypeCt" />
        /// </summary>
        /// <remarks>Дополнительные технологические реквизиты электронного документа (сведений)</remarks>
        [LxElementCt("EECEDocHeaderAddInfo", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUScatRu.EECEDocHeaderAddInfoTypeCt EECEDocHeaderAddInfo { get; set; } = new CustomsLiquidXml.XSD.RUScatRu.EECEDocHeaderAddInfoTypeCt();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>ИМ, ЭК, ТТ. Первый подраздел гр.1 ДТ/ТД</remarks>
        [LxElementValue("CustomsProcedure", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String CustomsProcedure { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код таможенной процедуры в соответствии с классификатором видов таможенных процедур. Гр. 1. Второй подраздел ДТ. Первый элемент первого подраздела гр. 37/«00» – для припасов</remarks>
        [LxElementValue("CustomsModeCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String CustomsModeCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Особенность помещения товаров под процедуру таможенного транзита. Гр. 1. Второй подраздел ТД. МПО - международные почтовые отправления, ФЛ - товары и (или) транспортные средства для личного пользования</remarks>
        [LxElementValue("TransitFeature", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "3")]
        public System.String TransitFeature { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>ИМ, ЭК, ТР, ВТ, ТС. Гр. 1 ТД. Третий подраздел</remarks>
        [LxElementValue("TransitDirectionCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String TransitDirectionCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак использования ДТ в форме электронного документа. ЭД. Гр. 1 ДТ. Третий подраздел</remarks>
        [LxElementValue("ElectronicDocumentSign", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String ElectronicDocumentSign { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код особенности декларирования товаров по классификатору особенностей таможенного декларирования товаров. Гр.7 ДТ</remarks>
        [LxElementValue("DeclarationKind", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "3")]
        public System.String DeclarationKind { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Признак недропользователя. Для РК</remarks>
        [LxElementValue("SubsoilSign", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "1")]
        public System.String SubsoilSign { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Номер (идентификатор) пломбиратора в ТД</remarks>
        [LxElementValue("SealNumber", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "10")]
        public List<System.String> SealNumbers { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Количество наложенных пломб в ТД</remarks>
        [LxElementValue("SealQuantity", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? SealQuantity { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Уникальный идентификационный номер защитной пломбы</remarks>
        [LxElementValue("SealId", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "20")]
        public List<System.String> SealIds { get; } = new List<System.String>();

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Описание отличительных признаков средств идентификации</remarks>
        [LxElementValue("SealDescriptionText", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "500")]
        public List<System.String> SealDescriptionTexts { get; } = new List<System.String>();

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Код страны, в сооветствии с классификатором стран мира, таможенного органа, которому представляется документ</remarks>
        [LxElementValue("RecipientCountryCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Pattern = "[A-Z]{2}|[0]{2}|[9]{2}")]
        public System.String RecipientCountryCode { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код цели перемещения в ТД</remarks>
        [LxElementValue("MovementCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "2")]
        public System.String MovementCode { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Место представления ТД</remarks>
        [LxElementValue("ExecutionPlace", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "35")]
        public System.String ExecutionPlace { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код ж/д станции. Гр.50 ТД</remarks>
        [LxElementValue("RailwayStationCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Pattern = "(\\d{5})|(\\d{6})")]
        public System.String RailwayStationCode { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Календарный штемпель ж/д станции - дата проставления</remarks>
        [LxElementValue("RailwayStampDate", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? RailwayStampDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Исходящий номер регистрации документов в соответствии с системой (регламентом) учета исходящих документов декларанта или таможенного представителя в Республике Беларусь</remarks>
        [LxElementValue("RegNumberDoc", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String RegNumberDoc { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код защитной наклейки для РК</remarks>
        [LxElementValue("SecurityLabelCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "6")]
        public System.String SecurityLabelCode { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsShipmentTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsShipmentTypeCt" />
        /// </summary>
        /// <remarks>Сведения о товарной партии</remarks>
        [LxElementCt("ESADout_CUGoodsShipment", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsShipmentTypeCt ESADout_CUGoodsShipment { get; set; } = new CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUGoodsShipmentTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt" />
        /// </summary>
        /// <remarks>Технические отметки для РБ/Сведения о корректировке (изменении) таможенной декларации</remarks>
        [LxElementCt("RBTechMarK", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.RBTechMarKTypeCt RBTechMarK { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения о лице, заполнившем документ</remarks>
        [LxElementCt("FilledPerson", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.SignatoryPersonDetailsTypeCt FilledPerson { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignCertifPersonTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignCertifPersonTypeCt" />
        /// </summary>
        /// <remarks>Сведения из сертификата электронной подписи</remarks>
        [LxElementCt("SignCertifPerson", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.SignCertifPersonTypeCt SignCertifPerson { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryRepresentativeDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.RUDECLcat.SignatoryRepresentativeDetailsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный представитель</remarks>
        [LxElementCt("CUESADCustomsRepresentative", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.RUDECLcat.SignatoryRepresentativeDetailsTypeCt CUESADCustomsRepresentative { get; set; }

    }

    /// <summary>A class representing the root XSD complexType PaymentDocumentType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Платежный документ</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:PaymentDocumentType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>657:2-677:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("PaymentDocumentType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class PaymentDocumentTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата уплаты или взыскания (дата исполнения обязанности по уплате таможенных и иных платежей)</remarks>
        [LxElementValue("PaymentDate", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? PaymentDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("DocumentModeCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocumentModeCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RBTechMarKType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Технические отметки для РБ/Сведения о корректировке (изменении) таможенной декларации</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:RBTechMarKType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>678:2-703:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("RBTechMarKType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class RBTechMarKTypeCt : CustomsLiquidXml.XSD.CatRu.DocumentBaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Вид корректировки в соответствии с классификатором видов корректировок</remarks>
        [LxElementValue("DelcKind", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 1, MaxOccurs = 1, Length = "2")]
        public System.String DelcKind { get; set; } = "";

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Optional : null when not set</summary>
        /// <remarks>Сумма подлежащая к уплате обеспечения. ТД</remarks>
        [LxElementValue("SumPayment", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 0, MaxOccurs = 1, TotalDigits = "20", FractionDigits = "2")]
        public LiquidTechnologies.XmlObjects.BigDecimal? SumPayment { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Код вида представляемого документа в соответствии с классификатором видов документов и сведений, используемых при таможенном декларировании</remarks>
        [LxElementValue("DocumentModeCode", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, Length = "5")]
        public System.String DocumentModeCode { get; set; }

    }

    /// <summary>A class representing the root XSD complexType TDDeliveryPlaceType@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Место назначения при транзите. гр 53 ТД</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/complexType:TDDeliveryPlaceType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>704:2-725:19</XsdLocation>
    [LxSimpleComplexTypeDefinition("TDDeliveryPlaceType", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0")]
    public partial class TDDeliveryPlaceTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер (регистрационный номер) зоны таможенного контроля</remarks>
        [LxElementValue("NumberCustomsZone", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String NumberCustomsZone { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt" />
        /// </summary>
        /// <remarks>Таможенный орган назначения при транзите.гр.53 ТД</remarks>
        [LxElementCt("DeliveryCustomsOffice", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt DeliveryCustomsOffice { get; set; } = new CustomsLiquidXml.XSD.CatRu.CUCustomsTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.ESADoutCU.AuthoriziedOperatorDetailsTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.ESADoutCU.AuthoriziedOperatorDetailsTypeCt" />
        /// </summary>
        /// <remarks>Сведения об уполномоченном экономическом операторе</remarks>
        [LxElementCt("AuthoriziedOperatorDetails", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.ESADoutCU.AuthoriziedOperatorDetailsTypeCt AuthoriziedOperatorDetails { get; set; }

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element ESADout_CU@urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0</summary>
    /// <remarks>Электронная копия декларации на товары и транзитной декларации</remarks>
    /// <XsdPath>schema:ESADout_CU.xsd/element:ESADout_CU</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ESADout_CU.xsd</XsdFile>
    /// <XsdLocation>13:2-17:15</XsdLocation>
    [LxSimpleElementDefinition("ESADout_CU", "urn:customs.ru:Information:CustomsDocuments:ESADout_CU:5.15.0", ElementScopeType.GlobalElement)]
    public partial class ESADout_CUElm : CustomsLiquidXml.XSD.ESADoutCU.ESADout_CUTypeCt
    {
    }

    #endregion

}

namespace CustomsLiquidXml.XSD
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class ESADoutCUValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public ESADoutCUValidator()
            : base(typeof(ESADoutCUValidator).Assembly, "CustomsLiquidXml.ESADoutCUResources.SchemaData")
        {
        }
    }
}