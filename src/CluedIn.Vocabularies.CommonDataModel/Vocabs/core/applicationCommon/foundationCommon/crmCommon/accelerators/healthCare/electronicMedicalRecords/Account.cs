using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for ElectronicMedicalRecords", group =>
            {
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodEndDate = group.Add(new VocabularyKey(nameof(Address1PeriodEndDate), "Primary - Primary End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address1PeriodStartDate = group.Add(new VocabularyKey(nameof(Address1PeriodStartDate), "Primary - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodEndDate = group.Add(new VocabularyKey(nameof(Address2PeriodEndDate), "Secondary  - Address Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Address2PeriodStartDate = group.Add(new VocabularyKey(nameof(Address2PeriodStartDate), "Secondary  - Address Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Alias = group.Add(new VocabularyKey(nameof(Alias), "DBA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1EndDate = group.Add(new VocabularyKey(nameof(Telecom1EndDate), "Primary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Rank = group.Add(new VocabularyKey(nameof(Telecom1Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom1StartDate = group.Add(new VocabularyKey(nameof(Telecom1StartDate), "Primary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1System = group.Add(new VocabularyKey(nameof(Telecom1System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom1Use = group.Add(new VocabularyKey(nameof(Telecom1Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2EndDate = group.Add(new VocabularyKey(nameof(Telecom2EndDate), "Secondary Phone End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Rank = group.Add(new VocabularyKey(nameof(Telecom2Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom2StartDate = group.Add(new VocabularyKey(nameof(Telecom2StartDate), "Secondary Phone Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2System = group.Add(new VocabularyKey(nameof(Telecom2System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom2Use = group.Add(new VocabularyKey(nameof(Telecom2Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3EndDate = group.Add(new VocabularyKey(nameof(Telecom3EndDate), "Primary Email End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Rank = group.Add(new VocabularyKey(nameof(Telecom3Rank), "Rank Of Contact", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Telecom3StartDate = group.Add(new VocabularyKey(nameof(Telecom3StartDate), "Primary Email Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3System = group.Add(new VocabularyKey(nameof(Telecom3System), "Telecom System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Telecom3Use = group.Add(new VocabularyKey(nameof(Telecom3Use), "Use Of Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey Address1PeriodEndDate { get; private set; }
        public VocabularyKey Address1PeriodStartDate { get; private set; }
        public VocabularyKey Address2PeriodEndDate { get; private set; }
        public VocabularyKey Address2PeriodStartDate { get; private set; }
        public VocabularyKey Alias { get; private set; }
        public VocabularyKey Telecom1EndDate { get; private set; }
        public VocabularyKey Telecom1Rank { get; private set; }
        public VocabularyKey Telecom1StartDate { get; private set; }
        public VocabularyKey Telecom1System { get; private set; }
        public VocabularyKey Telecom1Use { get; private set; }
        public VocabularyKey Telecom2EndDate { get; private set; }
        public VocabularyKey Telecom2Rank { get; private set; }
        public VocabularyKey Telecom2StartDate { get; private set; }
        public VocabularyKey Telecom2System { get; private set; }
        public VocabularyKey Telecom2Use { get; private set; }
        public VocabularyKey Telecom3EndDate { get; private set; }
        public VocabularyKey Telecom3Rank { get; private set; }
        public VocabularyKey Telecom3StartDate { get; private set; }
        public VocabularyKey Telecom3System { get; private set; }
        public VocabularyKey Telecom3Use { get; private set; }
    }
}