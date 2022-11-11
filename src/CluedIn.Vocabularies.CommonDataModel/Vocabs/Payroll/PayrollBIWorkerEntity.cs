using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollBIWorkerEntityVocabulary : SimpleVocabulary
    {
        public PayrollBIWorkerEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollBIWorkerEntity";
            KeyPrefix = "commonDataModel.payrollbiworkerentity";
            KeySeparator = ".";
            Grouping = "/PayrollBIWorkerEntity";

            AddGroup("Common Data Model PayrollBIWorkerEntity Details", group =>
            {
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUsingDirectDeposit = group.Add(new VocabularyKey(nameof(IsUsingDirectDeposit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey IsUsingDirectDeposit { get; private set; }


    }
}