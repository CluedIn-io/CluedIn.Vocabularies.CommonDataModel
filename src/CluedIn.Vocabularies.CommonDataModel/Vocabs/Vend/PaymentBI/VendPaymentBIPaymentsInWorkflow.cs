using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendPaymentBIPaymentsInWorkflowVocabulary : SimpleVocabulary
    {
        public VendPaymentBIPaymentsInWorkflowVocabulary()
        {
            VocabularyName = "VendPaymentBIPaymentsInWorkflow";
            KeyPrefix = "commonDataModel.vendpaymentbipaymentsinworkflow";
            KeySeparator = ".";
            Grouping = "/VendPaymentBIPaymentsInWorkflow";

            AddGroup("VendPaymentBIPaymentsInWorkflow Details", group =>
            {
                CompanyId = group.Add(new VocabularyKey(nameof(CompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedDateTime1 = group.Add(new VocabularyKey(nameof(CreatedDateTime1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Id = group.Add(new VocabularyKey(nameof(Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigurationNumber = group.Add(new VocabularyKey(nameof(ConfigurationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CompanyId { get; private set; }
        public VocabularyKey CreatedDateTime1 { get; private set; }
        public VocabularyKey Id { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey ConfigurationNumber { get; private set; }


    }
}