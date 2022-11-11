using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EFDocAuthorityEntityVocabulary : SimpleVocabulary
    {
        public EFDocAuthorityEntityVocabulary()
        {
            VocabularyName = "Common Data Model EFDocAuthorityEntity";
            KeyPrefix = "commonDataModel.efdocauthorityentity";
            KeySeparator = ".";
            Grouping = "/EFDocAuthorityEntity";

            AddGroup("Common Data Model EFDocAuthorityEntity Details", group =>
            {
                Authority = group.Add(new VocabularyKey(nameof(Authority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreAccents = group.Add(new VocabularyKey(nameof(IgnoreAccents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancelAsEvent = group.Add(new VocabularyKey(nameof(CancelAsEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AuthorityType = group.Add(new VocabularyKey(nameof(AuthorityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContingencyMode = group.Add(new VocabularyKey(nameof(ContingencyMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SVCAuthorityId = group.Add(new VocabularyKey(nameof(SVCAuthorityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NfceConsumerInquiryUrl = group.Add(new VocabularyKey(nameof(NfceConsumerInquiryUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NfceMaxAmountWithUnindentifiedCustomer = group.Add(new VocabularyKey(nameof(NfceMaxAmountWithUnindentifiedCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessNfceSynchronous = group.Add(new VocabularyKey(nameof(ProcessNfceSynchronous), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSTaxBaseAmountLimit = group.Add(new VocabularyKey(nameof(ICMSTaxBaseAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Authority { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IgnoreAccents { get; private set; }
        public VocabularyKey CancelAsEvent { get; private set; }
        public VocabularyKey AuthorityType { get; private set; }
        public VocabularyKey ContingencyMode { get; private set; }
        public VocabularyKey SVCAuthorityId { get; private set; }
        public VocabularyKey NfceConsumerInquiryUrl { get; private set; }
        public VocabularyKey NfceMaxAmountWithUnindentifiedCustomer { get; private set; }
        public VocabularyKey ProcessNfceSynchronous { get; private set; }
        public VocabularyKey ICMSTaxBaseAmountLimit { get; private set; }


    }
}