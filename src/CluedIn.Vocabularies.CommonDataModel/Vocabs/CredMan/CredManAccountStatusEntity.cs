using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManAccountStatusEntityVocabulary : SimpleVocabulary
    {
        public CredManAccountStatusEntityVocabulary()
        {
            VocabularyName = "CredManAccountStatusEntity";
            KeyPrefix = "commonDataModel.credmanaccountstatusentity";
            KeySeparator = ".";
            Grouping = "/CredManAccountStatusEntity";

            AddGroup("CredManAccountStatusEntity Details", group =>
            {
                CustAccountStatusDescription = group.Add(new VocabularyKey(nameof(CustAccountStatusDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustAccountStatusId = group.Add(new VocabularyKey(nameof(CustAccountStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustBlocked = group.Add(new VocabularyKey(nameof(CustBlocked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustAccountStatusDescription { get; private set; }
        public VocabularyKey CustAccountStatusId { get; private set; }
        public VocabularyKey CustBlocked { get; private set; }


    }
}