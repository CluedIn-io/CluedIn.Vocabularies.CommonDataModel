using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorCollaborationUserRequestEntityVocabulary : SimpleVocabulary
    {
        public VendVendorCollaborationUserRequestEntityVocabulary()
        {
            VocabularyName = "VendVendorCollaborationUserRequestEntity";
            KeyPrefix = "commonDataModel.vendvendorcollaborationuserrequestentity";
            KeySeparator = ".";
            Grouping = "/VendVendorCollaborationUserRequestEntity";

            AddGroup("VendVendorCollaborationUserRequestEntity Details", group =>
            {
                RequestAction = group.Add(new VocabularyKey(nameof(RequestAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestId = group.Add(new VocabularyKey(nameof(RequestId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestStatus = group.Add(new VocabularyKey(nameof(RequestStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserAlias = group.Add(new VocabularyKey(nameof(UserAlias), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserNetworkDomain = group.Add(new VocabularyKey(nameof(UserNetworkDomain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubmittedDateTime = group.Add(new VocabularyKey(nameof(SubmittedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResolvedDateTime = group.Add(new VocabularyKey(nameof(ResolvedDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserType = group.Add(new VocabularyKey(nameof(UserType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsersFullName = group.Add(new VocabularyKey(nameof(UsersFullName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsersLanguageId = group.Add(new VocabularyKey(nameof(UsersLanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessJustification = group.Add(new VocabularyKey(nameof(BusinessJustification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserEmail = group.Add(new VocabularyKey(nameof(UserEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RequestAction { get; private set; }
        public VocabularyKey RequestId { get; private set; }
        public VocabularyKey RequestStatus { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey UserAlias { get; private set; }
        public VocabularyKey UserNetworkDomain { get; private set; }
        public VocabularyKey SubmittedDateTime { get; private set; }
        public VocabularyKey ResolvedDateTime { get; private set; }
        public VocabularyKey UserType { get; private set; }
        public VocabularyKey UsersFullName { get; private set; }
        public VocabularyKey UsersLanguageId { get; private set; }
        public VocabularyKey BusinessJustification { get; private set; }
        public VocabularyKey UserEmail { get; private set; }


    }
}