using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmTotalCompStatementSectionHeaderEntityVocabulary : SimpleVocabulary
    {
        public HcmTotalCompStatementSectionHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model HcmTotalCompStatementSectionHeaderEntity";
            KeyPrefix = "commonDataModel.hcmtotalcompstatementsectionheaderentity";
            KeySeparator = ".";
            Grouping = "/HcmTotalCompStatementSectionHeaderEntity";

            AddGroup("Common Data Model HcmTotalCompStatementSectionHeaderEntity Details", group =>
            {
                StatementSectionId = group.Add(new VocabularyKey(nameof(StatementSectionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatementSectionName = group.Add(new VocabularyKey(nameof(StatementSectionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StatementSectionId { get; private set; }
public VocabularyKey StatementSectionName { get; private set; }


    }
}