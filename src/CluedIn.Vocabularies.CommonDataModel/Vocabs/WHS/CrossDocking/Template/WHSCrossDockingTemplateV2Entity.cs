using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCrossDockingTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSCrossDockingTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSCrossDockingTemplateV2Entity";
            KeyPrefix = "commonDataModel.whscrossdockingtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSCrossDockingTemplateV2Entity";

            AddGroup("Common Data Model WHSCrossDockingTemplateV2Entity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FEFOExpirationDaysRange = group.Add(new VocabularyKey(nameof(FEFOExpirationDaysRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PutLocationStorageCriteria = group.Add(new VocabularyKey(nameof(PutLocationStorageCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumTimeWindow = group.Add(new VocabularyKey(nameof(MaximumTimeWindow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumTimeWindowUnit = group.Add(new VocabularyKey(nameof(MaximumTimeWindowUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumTimeWindow = group.Add(new VocabularyKey(nameof(MinimumTimeWindow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumTimeWindowUnit = group.Add(new VocabularyKey(nameof(MinimumTimeWindowUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandRequirementRule = group.Add(new VocabularyKey(nameof(DemandRequirementRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReceiptRevalidateSupply = group.Add(new VocabularyKey(nameof(WillReceiptRevalidateSupply), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMaximumTimeWindowValidated = group.Add(new VocabularyKey(nameof(IsMaximumTimeWindowValidated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductQuery = group.Add(new VocabularyKey(nameof(ProductQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossDockingWorkTemplateId = group.Add(new VocabularyKey(nameof(CrossDockingWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DemandReleasePolicy = group.Add(new VocabularyKey(nameof(DemandReleasePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateId { get; private set; }
public VocabularyKey TemplateDescription { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey FEFOExpirationDaysRange { get; private set; }
public VocabularyKey PutLocationStorageCriteria { get; private set; }
public VocabularyKey MaximumTimeWindow { get; private set; }
public VocabularyKey MaximumTimeWindowUnit { get; private set; }
public VocabularyKey MinimumTimeWindow { get; private set; }
public VocabularyKey MinimumTimeWindowUnit { get; private set; }
public VocabularyKey DemandRequirementRule { get; private set; }
public VocabularyKey WillReceiptRevalidateSupply { get; private set; }
public VocabularyKey IsMaximumTimeWindowValidated { get; private set; }
public VocabularyKey ProductQuery { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }
public VocabularyKey CrossDockingWorkTemplateId { get; private set; }
public VocabularyKey DemandReleasePolicy { get; private set; }


    }
}