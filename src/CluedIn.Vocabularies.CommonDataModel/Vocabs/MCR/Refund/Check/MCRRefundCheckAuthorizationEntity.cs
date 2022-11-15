using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRRefundCheckAuthorizationEntityVocabulary : SimpleVocabulary
    {
        public MCRRefundCheckAuthorizationEntityVocabulary()
        {
            VocabularyName = "MCR Refund Check Authorization Entity";
            KeyPrefix = "commonDataModel.mcrrefundcheckauthorizationentity";
            KeySeparator = ".";
            Grouping = "/MCRRefundCheckAuthorizationEntity";

            AddGroup("MCRRefundCheckAuthorizationEntity Details", group =>
            {
                AuthorizedAmount = group.Add(new VocabularyKey(nameof(AuthorizedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizedBy = group.Add(new VocabularyKey(nameof(AuthorizedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizedDateTime = group.Add(new VocabularyKey(nameof(AuthorizedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorizationStatus = group.Add(new VocabularyKey(nameof(AuthorizationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesId = group.Add(new VocabularyKey(nameof(SalesId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentLineNumber = group.Add(new VocabularyKey(nameof(CustomerPaymentLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefundCheckSettlementLineNumber = group.Add(new VocabularyKey(nameof(RefundCheckSettlementLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AuthorizedAmount { get; private set; }
        public VocabularyKey AuthorizedBy { get; private set; }
        public VocabularyKey AuthorizedDateTime { get; private set; }
        public VocabularyKey AuthorizationStatus { get; private set; }
        public VocabularyKey SalesId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CustomerPaymentLineNumber { get; private set; }
        public VocabularyKey RefundCheckSettlementLineNumber { get; private set; }
    }
}