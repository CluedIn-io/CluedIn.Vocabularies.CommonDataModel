using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialDimensionDefaultTemplateEntityVocabulary : SimpleVocabulary
    {
        public FinancialDimensionDefaultTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model FinancialDimensionDefaultTemplateEntity";
            KeyPrefix = "commonDataModel.financialdimensiondefaulttemplateentity";
            KeySeparator = ".";
            Grouping = "/FinancialDimensionDefaultTemplateEntity";

            AddGroup("Common Data Model FinancialDimensionDefaultTemplateEntity Details", group =>
            {
                TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DistributionPercent = group.Add(new VocabularyKey(nameof(DistributionPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateName { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey LineNum { get; private set; }
public VocabularyKey DistributionPercent { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }


    }
}