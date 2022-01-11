using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectJournalApprovalEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectJournalApprovalEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectJournalApprovalEntity";
            KeyPrefix = "commonDataModel.projprojectjournalapprovalentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectJournalApprovalEntity";

            AddGroup("Common Data Model ProjProjectJournalApprovalEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Approve = group.Add(new VocabularyKey(nameof(Approve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Approve { get; private set; }


    }
}