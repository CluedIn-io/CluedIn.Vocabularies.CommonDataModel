using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPartyEmployeeRelationshipEntityVocabulary : SimpleVocabulary
    {
        public TrvPartyEmployeeRelationshipEntityVocabulary()
        {
            VocabularyName = "TrvPartyEmployeeRelationshipEntity";
            KeyPrefix = "commonDataModel.trvpartyemployeerelationshipentity";
            KeySeparator = ".";
            Grouping = "/TrvPartyEmployeeRelationshipEntity";

            AddGroup("TrvPartyEmployeeRelationshipEntity Details", group =>
            {
                AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerDiem = group.Add(new VocabularyKey(nameof(PerDiem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Employee = group.Add(new VocabularyKey(nameof(Employee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvHcmWorker_PersonnelNumber = group.Add(new VocabularyKey(nameof(TrvHcmWorker_PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Account { get; private set; }
        public VocabularyKey AccountDisplayValue { get; private set; }
        public VocabularyKey PerDiem { get; private set; }
        public VocabularyKey Employee { get; private set; }
        public VocabularyKey TrvHcmWorker_PersonnelNumber { get; private set; }


    }
}