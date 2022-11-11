using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSRoutePlanHubConfigurationEntityVocabulary : SimpleVocabulary
    {
        public TMSRoutePlanHubConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSRoutePlanHubConfigurationEntity";
            KeyPrefix = "commonDataModel.tmsrouteplanhubconfigurationentity";
            KeySeparator = ".";
            Grouping = "/TMSRoutePlanHubConfigurationEntity";

            AddGroup("Common Data Model TMSRoutePlanHubConfigurationEntity Details", group =>
            {
                TransportationHubId = group.Add(new VocabularyKey(nameof(TransportationHubId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccountType = group.Add(new VocabularyKey(nameof(InvoiceAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayingPartyRole = group.Add(new VocabularyKey(nameof(PayingPartyRole), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRoutePlanId = group.Add(new VocabularyKey(nameof(TransportationRoutePlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderVendorAccountNumber = group.Add(new VocabularyKey(nameof(OrderVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceVendorAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceVendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransportationHubId { get; private set; }
        public VocabularyKey InvoiceAccountType { get; private set; }
        public VocabularyKey PayingPartyRole { get; private set; }
        public VocabularyKey TransportationRoutePlanId { get; private set; }
        public VocabularyKey OrderVendorAccountNumber { get; private set; }
        public VocabularyKey InvoiceVendorAccountNumber { get; private set; }


    }
}