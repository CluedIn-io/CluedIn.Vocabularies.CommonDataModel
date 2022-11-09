using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSEstimateHoursEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSEstimateHoursEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjCDSEstimateHoursEntity";
            KeyPrefix = "commonDataModel.projcdsestimatehoursentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSEstimateHoursEntity";

            AddGroup("Common Data Model ProjCDSEstimateHoursEntity Details", group =>
            {
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedCostAmount = group.Add(new VocabularyKey(nameof(PlannedCostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedSalesAmount = group.Add(new VocabularyKey(nameof(PlannedSalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ForecastModel = group.Add(new VocabularyKey(nameof(ForecastModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TaskId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey SalesCurrency { get; private set; }
public VocabularyKey ExchangeRate { get; private set; }
public VocabularyKey PlannedCostAmount { get; private set; }
public VocabularyKey PlannedSalesAmount { get; private set; }
public VocabularyKey Duration { get; private set; }
public VocabularyKey ForecastModel { get; private set; }
public VocabularyKey StartDate { get; private set; }


    }
}