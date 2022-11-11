using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailNotificationSubscriptionsEntityVocabulary : SimpleVocabulary
    {
        public RetailNotificationSubscriptionsEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailNotificationSubscriptionsEntity";
            KeyPrefix = "commonDataModel.retailnotificationsubscriptionsentity";
            KeySeparator = ".";
            Grouping = "/RetailNotificationSubscriptionsEntity";

            AddGroup("Common Data Model RetailNotificationSubscriptionsEntity Details", group =>
            {
                DisplayOrder = group.Add(new VocabularyKey(nameof(DisplayOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailOperation = group.Add(new VocabularyKey(nameof(RetailOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPosPermissionGroup = group.Add(new VocabularyKey(nameof(RetailPosPermissionGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailPosPermissionGroup_PosPermissionGroupId = group.Add(new VocabularyKey(nameof(RetailPosPermissionGroup_PosPermissionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailOperation_OperationId = group.Add(new VocabularyKey(nameof(RetailOperation_OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DisplayOrder { get; private set; }
        public VocabularyKey RetailOperation { get; private set; }
        public VocabularyKey RetailPosPermissionGroup { get; private set; }
        public VocabularyKey RetailPosPermissionGroup_PosPermissionGroupId { get; private set; }
        public VocabularyKey RetailOperation_OperationId { get; private set; }


    }
}