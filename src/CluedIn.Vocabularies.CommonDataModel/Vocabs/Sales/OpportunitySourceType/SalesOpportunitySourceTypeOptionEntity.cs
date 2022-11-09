using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOpportunitySourceTypeOptionEntityVocabulary : SimpleVocabulary
    {
        public SalesOpportunitySourceTypeOptionEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOpportunitySourceTypeOptionEntity";
            KeyPrefix = "commonDataModel.salesopportunitysourcetypeoptionentity";
            KeySeparator = ".";
            Grouping = "/SalesOpportunitySourceTypeOptionEntity";

            AddGroup("Common Data Model SalesOpportunitySourceTypeOptionEntity Details", group =>
            {
                OptionDescription = group.Add(new VocabularyKey(nameof(OptionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptionName = group.Add(new VocabularyKey(nameof(OptionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OpportunitySourceType = group.Add(new VocabularyKey(nameof(OpportunitySourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OpportunitySourceTypeUserDefinedSourceTypeName = group.Add(new VocabularyKey(nameof(OpportunitySourceTypeUserDefinedSourceTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey OptionDescription { get; private set; }
public VocabularyKey OptionName { get; private set; }
public VocabularyKey OpportunitySourceType { get; private set; }
public VocabularyKey OpportunitySourceTypeUserDefinedSourceTypeName { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}