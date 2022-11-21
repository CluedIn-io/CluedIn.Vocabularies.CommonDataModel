using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRSalesOrderHoldCodeEntityVocabulary : SimpleVocabulary
    {
        public MCRSalesOrderHoldCodeEntityVocabulary()
        {
            VocabularyName = "MCR Sales Order Hold Code Entity";
            KeyPrefix = "commonDataModel.mcrsalesorderholdcodeentity";
            KeySeparator = ".";
            Grouping = "/MCRSalesOrderHoldCodeEntity";

            AddGroup("MCRSalesOrderHoldCodeEntity Details", group =>
            {
                SalesOrderHoldCode = group.Add(new VocabularyKey(nameof(SalesOrderHoldCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedSecurityRoleId = group.Add(new VocabularyKey(nameof(AssociatedSecurityRoleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedSecurityRoleName = group.Add(new VocabularyKey(nameof(AssociatedSecurityRoleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultSalesOrderHoldCode = group.Add(new VocabularyKey(nameof(IsDefaultSalesOrderHoldCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsHoldCodeRemovingInventoryReservations = group.Add(new VocabularyKey(nameof(IsHoldCodeRemovingInventoryReservations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SalesOrderHoldCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AssociatedSecurityRoleId { get; private set; }
        public VocabularyKey AssociatedSecurityRoleName { get; private set; }
        public VocabularyKey IsDefaultSalesOrderHoldCode { get; private set; }
        public VocabularyKey IsHoldCodeRemovingInventoryReservations { get; private set; }
    }
}