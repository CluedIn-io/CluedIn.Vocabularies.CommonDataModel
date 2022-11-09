using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataManagementTemplateSourceEntityVocabulary : SimpleVocabulary
    {
        public DataManagementTemplateSourceEntityVocabulary()
        {
            VocabularyName = "Common Data Model DataManagementTemplateSourceEntity";
            KeyPrefix = "commonDataModel.datamanagementtemplatesourceentity";
            KeySeparator = ".";
            Grouping = "/DataManagementTemplateSourceEntity";

            AddGroup("Common Data Model DataManagementTemplateSourceEntity Details", group =>
            {
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceEntity = group.Add(new VocabularyKey(nameof(SourceEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateId { get; private set; }
public VocabularyKey SourceEntity { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}