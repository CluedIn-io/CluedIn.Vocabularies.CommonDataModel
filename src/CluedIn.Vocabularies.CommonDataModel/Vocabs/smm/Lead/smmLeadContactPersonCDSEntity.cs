using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmLeadContactPersonCDSEntityVocabulary : SimpleVocabulary
    {
        public smmLeadContactPersonCDSEntityVocabulary()
        {
            VocabularyName = "smmLeadContactPersonCDSEntity";
            KeyPrefix = "commonDataModel.smmleadcontactpersoncdsentity";
            KeySeparator = ".";
            Grouping = "/smmLeadContactPersonCDSEntity";

            AddGroup("smmLeadContactPersonCDSEntity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadId = group.Add(new VocabularyKey(nameof(LeadId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ContactPersonPartyNumber { get; private set; }
        public VocabularyKey LeadId { get; private set; }


    }
}