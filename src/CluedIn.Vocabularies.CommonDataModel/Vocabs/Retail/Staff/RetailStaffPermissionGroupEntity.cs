using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailStaffPermissionGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailStaffPermissionGroupEntityVocabulary()
        {
            VocabularyName = "Retail Staff Permission Group Entity";
            KeyPrefix = "commonDataModel.retailstaffpermissiongroupentity";
            KeySeparator = ".";
            Grouping = "/RetailStaffPermissionGroupEntity";

            AddGroup("RetailStaffPermissionGroupEntity Details", group =>
            {
                IsAllowChangeNoVoid = group.Add(new VocabularyKey(nameof(IsAllowChangeNoVoid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowFloatingTenderDeclaration = group.Add(new VocabularyKey(nameof(IsAllowFloatingTenderDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowOpenDrawerOnly = group.Add(new VocabularyKey(nameof(IsAllowOpenDrawerOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowPriceOverride = group.Add(new VocabularyKey(nameof(AllowPriceOverride), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowTenderDeclaration = group.Add(new VocabularyKey(nameof(IsAllowTenderDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowTransactionSuspension = group.Add(new VocabularyKey(nameof(IsAllowTransactionSuspension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowTransactionVoiding = group.Add(new VocabularyKey(nameof(IsAllowTransactionVoiding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowXReportPrinting = group.Add(new VocabularyKey(nameof(IsAllowXReportPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAllowZReportPrinting = group.Add(new VocabularyKey(nameof(IsAllowZReportPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsManagerPrivileges = group.Add(new VocabularyKey(nameof(IsManagerPrivileges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxDiscountPercent = group.Add(new VocabularyKey(nameof(MaxDiscountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxLineDiscountAmount = group.Add(new VocabularyKey(nameof(MaxLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxTotalDiscountAmount = group.Add(new VocabularyKey(nameof(MaxTotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxTotalDiscountPercent = group.Add(new VocabularyKey(nameof(MaxTotalDiscountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PermissionGroupName = group.Add(new VocabularyKey(nameof(PermissionGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PermissionGroupId = group.Add(new VocabularyKey(nameof(PermissionGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsAllowChangeNoVoid { get; private set; }
        public VocabularyKey IsAllowFloatingTenderDeclaration { get; private set; }
        public VocabularyKey IsAllowOpenDrawerOnly { get; private set; }
        public VocabularyKey AllowPriceOverride { get; private set; }
        public VocabularyKey IsAllowTenderDeclaration { get; private set; }
        public VocabularyKey IsAllowTransactionSuspension { get; private set; }
        public VocabularyKey IsAllowTransactionVoiding { get; private set; }
        public VocabularyKey IsAllowXReportPrinting { get; private set; }
        public VocabularyKey IsAllowZReportPrinting { get; private set; }
        public VocabularyKey IsManagerPrivileges { get; private set; }
        public VocabularyKey MaxDiscountPercent { get; private set; }
        public VocabularyKey MaxLineDiscountAmount { get; private set; }
        public VocabularyKey MaxTotalDiscountAmount { get; private set; }
        public VocabularyKey MaxTotalDiscountPercent { get; private set; }
        public VocabularyKey PermissionGroupName { get; private set; }
        public VocabularyKey PermissionGroupId { get; private set; }
    }
}