using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationSalesLoadBuildingTemplateEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationSalesLoadBuildingTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationSalesLoadBuildingTemplateEntity";
            KeyPrefix = "commonDataModel.tmstransportationsalesloadbuildingtemplateentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationSalesLoadBuildingTemplateEntity";

            AddGroup("Common Data Model TMSTransportationSalesLoadBuildingTemplateEntity Details", group =>
            {
                OrderingCustomerAccountNumber = group.Add(new VocabularyKey(nameof(OrderingCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationCountryRegionId = group.Add(new VocabularyKey(nameof(DestinationCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationFromZipCode = group.Add(new VocabularyKey(nameof(DestinationFromZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DestinationToZipCode = group.Add(new VocabularyKey(nameof(DestinationToZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FirstProductFilterCode = group.Add(new VocabularyKey(nameof(FirstProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondProductFilterCode = group.Add(new VocabularyKey(nameof(SecondProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdProductFilterCode = group.Add(new VocabularyKey(nameof(ThirdProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FourthProductFilterCode = group.Add(new VocabularyKey(nameof(FourthProductFilterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationLoadBuildStrategy = group.Add(new VocabularyKey(nameof(TransportationLoadBuildStrategy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginCountryRegionId = group.Add(new VocabularyKey(nameof(OriginCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginFromZipCode = group.Add(new VocabularyKey(nameof(OriginFromZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginWarehouseId = group.Add(new VocabularyKey(nameof(OriginWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginOperationalSiteId = group.Add(new VocabularyKey(nameof(OriginOperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OriginToZipCode = group.Add(new VocabularyKey(nameof(OriginToZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesOrderFilterQuery = group.Add(new VocabularyKey(nameof(SalesOrderFilterQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationLoadBuildingStrategyName = group.Add(new VocabularyKey(nameof(TransportationLoadBuildingStrategyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OrderingCustomerAccountNumber { get; private set; }
public VocabularyKey TemplateDescription { get; private set; }
public VocabularyKey DestinationCountryRegionId { get; private set; }
public VocabularyKey DestinationFromZipCode { get; private set; }
public VocabularyKey DestinationToZipCode { get; private set; }
public VocabularyKey FirstProductFilterCode { get; private set; }
public VocabularyKey SecondProductFilterCode { get; private set; }
public VocabularyKey ThirdProductFilterCode { get; private set; }
public VocabularyKey FourthProductFilterCode { get; private set; }
public VocabularyKey TransportationLoadBuildStrategy { get; private set; }
public VocabularyKey TemplateName { get; private set; }
public VocabularyKey OriginCountryRegionId { get; private set; }
public VocabularyKey OriginFromZipCode { get; private set; }
public VocabularyKey OriginWarehouseId { get; private set; }
public VocabularyKey OriginOperationalSiteId { get; private set; }
public VocabularyKey OriginToZipCode { get; private set; }
public VocabularyKey SalesOrderFilterQuery { get; private set; }
public VocabularyKey TransportationLoadBuildingStrategyName { get; private set; }


    }
}