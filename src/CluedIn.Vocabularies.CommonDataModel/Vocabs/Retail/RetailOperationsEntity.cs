using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailOperationsEntityVocabulary : SimpleVocabulary
    {
        public RetailOperationsEntityVocabulary()
        {
            VocabularyName = "RetailOperationsEntity";
            KeyPrefix = "commonDataModel.retailoperationsentity";
            KeySeparator = ".";
            Grouping = "/RetailOperationsEntity";

            AddGroup("RetailOperationsEntity Details", group =>
            {
                OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActionPropertyLookupType = group.Add(new VocabularyKey(nameof(ActionPropertyLookupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckUserAccess = group.Add(new VocabularyKey(nameof(CheckUserAccess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationName = group.Add(new VocabularyKey(nameof(OperationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PermissionId = group.Add(new VocabularyKey(nameof(PermissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PermissionId2 = group.Add(new VocabularyKey(nameof(PermissionId2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserOperation = group.Add(new VocabularyKey(nameof(UserOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableNotifications = group.Add(new VocabularyKey(nameof(EnableNotifications), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey OperationId { get; private set; }
        public VocabularyKey ActionPropertyLookupType { get; private set; }
        public VocabularyKey CheckUserAccess { get; private set; }
        public VocabularyKey OperationName { get; private set; }
        public VocabularyKey PermissionId { get; private set; }
        public VocabularyKey PermissionId2 { get; private set; }
        public VocabularyKey UserOperation { get; private set; }
        public VocabularyKey EnableNotifications { get; private set; }


    }
}