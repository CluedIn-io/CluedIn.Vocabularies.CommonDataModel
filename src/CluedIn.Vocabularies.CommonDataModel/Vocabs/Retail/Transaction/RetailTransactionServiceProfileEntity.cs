using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionServiceProfileEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionServiceProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionServiceProfileEntity";
            KeyPrefix = "commonDataModel.retailtransactionserviceprofileentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionServiceProfileEntity";

            AddGroup("Common Data Model RetailTransactionServiceProfileEntity Details", group =>
            {
                CentralTableServer = group.Add(new VocabularyKey(nameof(CentralTableServer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CentralTableServerPort = group.Add(new VocabularyKey(nameof(CentralTableServerPort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PosTSPassword = group.Add(new VocabularyKey(nameof(PosTSPassword), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Protocol = group.Add(new VocabularyKey(nameof(Protocol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTSData = group.Add(new VocabularyKey(nameof(RetailTSData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecurityOff = group.Add(new VocabularyKey(nameof(SecurityOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServerCertificateDNS = group.Add(new VocabularyKey(nameof(ServerCertificateDNS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServerServiceName = group.Add(new VocabularyKey(nameof(ServerServiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TSStaff = group.Add(new VocabularyKey(nameof(TSStaff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TSVersion = group.Add(new VocabularyKey(nameof(TSVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportExecutionTimeout = group.Add(new VocabularyKey(nameof(ReportExecutionTimeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferFileChunkSize = group.Add(new VocabularyKey(nameof(TransferFileChunkSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceHostUrl = group.Add(new VocabularyKey(nameof(ServiceHostUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssuerUri = group.Add(new VocabularyKey(nameof(IssuerUri), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentityProvider = group.Add(new VocabularyKey(nameof(IdentityProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IdentityProviderClaimType = group.Add(new VocabularyKey(nameof(IdentityProviderClaimType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IssuedTokenType = group.Add(new VocabularyKey(nameof(IssuedTokenType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AudienceUrn = group.Add(new VocabularyKey(nameof(AudienceUrn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AosUrl = group.Add(new VocabularyKey(nameof(AosUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CentralTableServer { get; private set; }
        public VocabularyKey CentralTableServerPort { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PosTSPassword { get; private set; }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey Protocol { get; private set; }
        public VocabularyKey RetailTSData { get; private set; }
        public VocabularyKey SecurityOff { get; private set; }
        public VocabularyKey ServerCertificateDNS { get; private set; }
        public VocabularyKey ServerServiceName { get; private set; }
        public VocabularyKey TSStaff { get; private set; }
        public VocabularyKey TSVersion { get; private set; }
        public VocabularyKey ReportExecutionTimeout { get; private set; }
        public VocabularyKey TransferFileChunkSize { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey ServiceHostUrl { get; private set; }
        public VocabularyKey IssuerUri { get; private set; }
        public VocabularyKey IdentityProvider { get; private set; }
        public VocabularyKey IdentityProviderClaimType { get; private set; }
        public VocabularyKey IssuedTokenType { get; private set; }
        public VocabularyKey AudienceUrn { get; private set; }
        public VocabularyKey AosUrl { get; private set; }


    }
}