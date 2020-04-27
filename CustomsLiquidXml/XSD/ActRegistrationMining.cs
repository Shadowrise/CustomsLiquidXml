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
//    C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd

namespace CustomsLiquidXml.XSD.Arm
{
    #region Complex Types
    /// <summary>A class representing the root XSD complexType ActRegistrationMiningType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Акт регистрации объемов добычи (вылова) при выгрузке в порту (пункте выгрузки)/при перегрузке промысловым судном.</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:ActRegistrationMiningType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>9:3-104:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("ActRegistrationMiningType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class ActRegistrationMiningTypeCt : CustomsLiquidXml.XSD.CatRu.BaseDocTypeCt
    {
        /// <summary>The value for the attribute DocumentModeID</summary>
        /// <remarks>Идентификатор вида документа</remarks>
        /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:ActRegistrationMiningType/attribute:DocumentModeID</XsdPath>
        /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
        /// <XsdLocation>97:9-101:24</XsdLocation>
        [LxAttribute("DocumentModeID", "", LxValueType.Value, XsdType.XsdToken, Required = true, MinLength = "1", MaxLength = "30")]
        public System.String DocumentModeID { get; set; } = "1006105E";

        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование пограничного управления береговой охраны (пограничного управления))</remarks>
        [LxElementValue("NameManagement", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String NameManagement { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата составления акта</remarks>
        [LxElementValue("DateAct", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime DateAct { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата начала перегрузки/выгрузки</remarks>
        [LxElementValue("StartDate", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime StartDate { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Время начала перегрузки/выгрузки</remarks>
        [LxElementValue("StartTime", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime StartTime { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата окончания перегрузки/выгрузки</remarks>
        [LxElementValue("EndDate", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EndDate { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Время окончания перегрузки/выгрузки</remarks>
        [LxElementValue("EndTime", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? EndTime { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Акт регистрации объемов добычи (вылова) при: 0 - выгрузке, 1 - перегрузке</remarks>
        [LxElementValue("OverloadUnloading", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal OverloadUnloading { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.RegistrationNumberTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.RegistrationNumberTypeCt" />
        /// </summary>
        /// <remarks>Регистрационный номер акта</remarks>
        [LxElementCt("RegistrationNumber", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.Arm.RegistrationNumberTypeCt RegistrationNumber { get; set; } = new CustomsLiquidXml.XSD.Arm.RegistrationNumberTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.AddressTypeCt" />
        /// </summary>
        /// <remarks>Место составления акта</remarks>
        [LxElementCt("ExecutionPlace", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.AddressTypeCt ExecutionPlace { get; set; } = new CustomsLiquidXml.XSD.CatRu.AddressTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />
        /// </summary>
        /// <remarks>Сведение о передающем судне или судне, которого осуществляется выгрузка</remarks>
        [LxElementCt("Vessel", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.Arm.VesselTypeCt Vessel { get; set; } = new CustomsLiquidXml.XSD.Arm.VesselTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />
        /// </summary>
        /// <remarks>Сведения о принимающем судне</remarks>
        [LxElementCt("ReceivingVessel", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.Arm.VesselTypeCt ReceivingVessel { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.VesselTypeCt" />
        /// </summary>
        /// <remarks>Сведения о судне, с которого добыто рыбное сырье и рыбопродукция</remarks>
        [LxElementCt("VesselExtracted", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.Arm.VesselTypeCt VesselExtracted { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.RegistrationTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.RegistrationTypeCt" />
        /// </summary>
        /// <remarks>Регистрация</remarks>
        [LxElementCt("Registration", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.Arm.RegistrationTypeCt> Registrations { get; } = new List<CustomsLiquidXml.XSD.Arm.RegistrationTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />
        /// </summary>
        /// <remarks>Подпись инспектора</remarks>
        [LxElementCt("InspectorSignature", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt> InspectorSignatures { get; } = new List<CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />
        /// </summary>
        /// <remarks>Подпись капитана судна</remarks>
        [LxElementCt("ShipmasterSignature", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt ShipmasterSignature { get; set; } = new CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.RegistrationDatabaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.RegistrationDatabaseTypeCt" />
        /// </summary>
        /// <remarks>Регистрация в базе данных</remarks>
        [LxElementCt("RegistrationDatabase", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.Arm.RegistrationDatabaseTypeCt RegistrationDatabase { get; set; }

    }

    /// <summary>A class representing the root XSD complexType ProductListType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Лист зарегистрированной продукции</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:ProductListType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>108:3-154:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("ProductListType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class ProductListTypeCt
    {
        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Вид продукции</remarks>
        [LxElementValue("ProductType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> ProductTypes { get; } = new List<System.String>();

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Вес (нетто), кг</remarks>
        [LxElementValue("Weigh", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "6", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal Weigh { get; set; }

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Коэффициент пересчета готовой продукции в сырец</remarks>
        [LxElementValue("ConversionFactor", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? ConversionFactor { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>Объем использованного сырца, кг</remarks>
        [LxElementValue("Quantity", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "24", FractionDigits = "6")]
        public LiquidTechnologies.XmlObjects.BigDecimal Quantity { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Район добычи (зона, подзона)</remarks>
        [LxElementValue("AreaMining", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> AreaMinings { get; } = new List<System.String>();

        /// <summary>A nullable <see cref="System.Numerics.BigInteger" />, Optional : null when not set</summary>
        /// <remarks>Сроки добычи</remarks>
        [LxElementValue("TimingExtraction", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 0, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger? TimingExtraction { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Единица измерения срока добычи</remarks>
        [LxElementValue("MeasurementUnitTime", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "13")]
        public System.String MeasurementUnitTime { get; set; }

        /// <summary>A collection of <see cref="System.String" /></summary>
        /// <remarks>Грузополучатель (куда направлена или кому предназначена продукция)</remarks>
        [LxElementValue("Consignee", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = LxConstants.Unbounded, MinLength = "1", MaxLength = "250")]
        public List<System.String> Consignees { get; } = new List<System.String>();

    }

    /// <summary>A class representing the root XSD complexType RegistrationDatabaseType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Регистрация в базе данных</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:RegistrationDatabaseType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>155:3-181:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegistrationDatabaseType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class RegistrationDatabaseTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Способ передачи</remarks>
        [LxElementValue("TransferMethod", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String TransferMethod { get; set; } = "";

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата передачи</remarks>
        [LxElementValue("DateTransfer", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime DateTransfer { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Время передачи</remarks>
        [LxElementValue("TimeTransfer", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdTime, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime TimeTransfer { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt" />
        /// </summary>
        /// <remarks>Подпись</remarks>
        [LxElementCt("PersonSignature", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt PersonSignature { get; set; } = new CustomsLiquidXml.XSD.CatRu.PersonSignatureTypeCt();

    }

    /// <summary>A class representing the root XSD complexType RegistrationNumberType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Регистрационный номер акта</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:RegistrationNumberType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>182:3-198:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegistrationNumberType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class RegistrationNumberTypeCt
    {
        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Персональный номер государственного инспектора</remarks>
        [LxElementValue("NumberInspectors", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger NumberInspectors { get; set; }

        /// <summary>A <see cref="System.Numerics.BigInteger" />, Required</summary>
        /// <remarks>Порядковый номер акта</remarks>
        [LxElementValue("SerialNumber", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdInteger, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "3")]
        public System.Numerics.BigInteger SerialNumber { get; set; }

    }

    /// <summary>A class representing the root XSD complexType RegistrationType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Регистрация</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:RegistrationType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>199:3-230:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("RegistrationType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class RegistrationTypeCt
    {
        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата начала периода</remarks>
        [LxElementValue("StartDate", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime StartDate { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Required</summary>
        /// <remarks>Дата окончания периода</remarks>
        [LxElementValue("EndDate", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 1, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime EndDate { get; set; }

        /// <summary>A <see cref="LiquidTechnologies.XmlObjects.BigDecimal" />, Required</summary>
        /// <remarks>В счет квот добычи (вылова) водных биоресурсов для осуществления: 1- промышленного рыболовства; 2- прибрежного рыболовства; 3-рыболовства в научно-исследовательских и контрольных целях в соответствии с разрешениями.</remarks>
        [LxElementValue("Action", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDecimal, MinOccurs = 1, MaxOccurs = 1, MinInclusive = "0", TotalDigits = "1", FractionDigits = "0")]
        public LiquidTechnologies.XmlObjects.BigDecimal Action { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.ResolutionTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.ResolutionTypeCt" />
        /// </summary>
        /// <remarks>Разрешение</remarks>
        [LxElementCt("Resolution", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.Arm.ResolutionTypeCt> Resolutions { get; } = new List<CustomsLiquidXml.XSD.Arm.ResolutionTypeCt>();

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.Arm.ProductListTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.Arm.ProductListTypeCt" />
        /// </summary>
        /// <remarks>Лист зарегистрированной продукции</remarks>
        [LxElementCt("ProductList", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 0, MaxOccurs = LxConstants.Unbounded)]
        public List<CustomsLiquidXml.XSD.Arm.ProductListTypeCt> ProductLists { get; } = new List<CustomsLiquidXml.XSD.Arm.ProductListTypeCt>();

    }

    /// <summary>A class representing the root XSD complexType ResolutionType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Разрешение</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:ResolutionType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>231:3-252:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("ResolutionType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class ResolutionTypeCt
    {
        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Номер разрешения</remarks>
        [LxElementValue("ResolutionNumber", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "50")]
        public System.String ResolutionNumber { get; set; }

        /// <summary>A nullable <see cref="LiquidTechnologies.XmlObjects.LxDateTime" />, Optional : null when not set</summary>
        /// <remarks>Дата разрешения</remarks>
        [LxElementValue("ResolutionDate", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdDate, MinOccurs = 0, MaxOccurs = 1)]
        public LiquidTechnologies.XmlObjects.LxDateTime? ResolutionDate { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Кем выдано</remarks>
        [LxElementValue("Issued", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String Issued { get; set; }

    }

    /// <summary>A class representing the root XSD complexType VesselType@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <remarks>Сведения о судне</remarks>
    /// <XsdPath>schema:ActRegistrationMining.xsd/complexType:VesselType</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>253:3-279:20</XsdLocation>
    [LxSimpleComplexTypeDefinition("VesselType", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0")]
    public partial class VesselTypeCt
    {
        /// <summary>A <see cref="System.String" />, Required : should not be set to null</summary>
        /// <remarks>Наименование судна</remarks>
        [LxElementValue("Name", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 1, MaxOccurs = 1, MinLength = "1", MaxLength = "150")]
        public System.String Name { get; set; } = "";

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Тип судна</remarks>
        [LxElementValue("Type", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdString, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "250")]
        public System.String Type { get; set; }

        /// <summary>A <see cref="System.String" />, Optional : null when not set</summary>
        /// <remarks>Бортовой номер судна</remarks>
        [LxElementValue("NumberBoard", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", LxValueType.Value, XsdType.XsdToken, MinOccurs = 0, MaxOccurs = 1, MinLength = "1", MaxLength = "7")]
        public System.String NumberBoard { get; set; }

        /// <summary>
        ///   A class derived from <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt" />.<br/><br/>
        ///   Allowable types are <br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.CUOrganizationTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationBackAddrTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationTypeCt" /><br/>
        ///       <see cref="CustomsLiquidXml.XSD.CatRu.OrganizationWBankTypeCt" />
        /// </summary>
        /// <remarks>Сведения о судовладельце</remarks>
        [LxElementCt("Shipowner", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", MinOccurs = 1, MaxOccurs = 1)]
        public CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt Shipowner { get; set; } = new CustomsLiquidXml.XSD.CatRu.OrganizationBaseTypeCt();

    }

    #endregion

    #region Elements
    /// <summary>A class representing the root XSD element ActRegistrationMining@urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0</summary>
    /// <XsdPath>schema:ActRegistrationMining.xsd/element:ActRegistrationMining</XsdPath>
    /// <XsdFile>C:\Users\Viacheslav\source\repos\CustomsLiquidXml\CustomsLiquidXml\XSD\ActRegistrationMining.xsd</XsdFile>
    /// <XsdLocation>8:3-8:83</XsdLocation>
    [LxSimpleElementDefinition("ActRegistrationMining", "urn:customs.ru:Information:CustomsDocuments:ActRegistrationMining:5.10.0", ElementScopeType.GlobalElement)]
    public partial class ActRegistrationMiningElm : CustomsLiquidXml.XSD.Arm.ActRegistrationMiningTypeCt
    {
    }

    #endregion

}

namespace CustomsLiquidXml.XSD
{
    /// <summary>
    /// Provides a validator based on the original XSD schema files. 
    /// </summary>
    public partial class ActRegistrationMiningValidator : LiquidTechnologies.XmlObjects.XsdValidator
    {
        /// <summary>
        /// Initializes the validator, loads and compiles the XSD schemas.
        /// </summary>
        /// <remarks>
        /// This is an expensive operation so consider caching this object.
        /// </remarks>
        public ActRegistrationMiningValidator()
            : base(typeof(ActRegistrationMiningValidator).Assembly, "CustomsLiquidXml.ActRegistrationMiningResources.SchemaData")
        {
        }
    }
}