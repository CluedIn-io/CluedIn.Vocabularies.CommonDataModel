using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOpportunitySourceTypeEntityVocabulary : SimpleVocabulary
    {
        public SalesOpportunitySourceTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOpportunitySourceTypeEntity";
            KeyPrefix = "commonDataModel.salesopportunitysourcetypeentity";
            KeySeparator = ".";
            Grouping = "/SalesOpportunitySourceTypeEntity";

            AddGroup("Common Data Model SalesOpportunitySourceTypeEntity Details", group =>
            {
                IsFreeformTextAllowed = group.Add(new VocabularyKey(nameof(IsFreeformTextAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceType = group.Add(new VocabularyKey(nameof(SourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserDefinedSourceTypeName = group.Add(new VocabularyKey(nameof(UserDefinedSourceTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceTypeId = group.Add(new VocabularyKey(nameof(SourceTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UserDefinedSourceTypeDescription = group.Add(new VocabularyKey(nameof(UserDefinedSourceTypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsFreeformTextAllowed { get; private set; }
public VocabularyKey SourceType { get; private set; }
public VocabularyKey UserDefinedSourceTypeName { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey SourceTypeId { get; private set; }
public VocabularyKey UserDefinedSourceTypeDescription { get; private set; }


    }
}