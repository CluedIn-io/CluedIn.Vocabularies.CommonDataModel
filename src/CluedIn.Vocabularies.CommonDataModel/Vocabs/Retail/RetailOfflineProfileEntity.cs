using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailOfflineProfileEntityVocabulary : SimpleVocabulary
    {
        public RetailOfflineProfileEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailOfflineProfileEntity";
            KeyPrefix = "commonDataModel.retailofflineprofileentity";
            KeySeparator = ".";
            Grouping = "/RetailOfflineProfileEntity";

            AddGroup("Common Data Model RetailOfflineProfileEntity Details", group =>
            {
                AddressBook = group.Add(new VocabularyKey(nameof(AddressBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Assortment = group.Add(new VocabularyKey(nameof(Assortment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNewDBInterval = group.Add(new VocabularyKey(nameof(CheckNewDBInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DBExportPath = group.Add(new VocabularyKey(nameof(DBExportPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImagePath = group.Add(new VocabularyKey(nameof(ImagePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UploadTransactionSize = group.Add(new VocabularyKey(nameof(UploadTransactionSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReconnectInterval = group.Add(new VocabularyKey(nameof(ReconnectInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Timeout = group.Add(new VocabularyKey(nameof(Timeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerByAddress = group.Add(new VocabularyKey(nameof(CustomerByAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerBySalesAmount = group.Add(new VocabularyKey(nameof(CustomerBySalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerBySalesAmountDayLimit = group.Add(new VocabularyKey(nameof(CustomerBySalesAmountDayLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerBySalesAmountNumLimit = group.Add(new VocabularyKey(nameof(CustomerBySalesAmountNumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerByVisits = group.Add(new VocabularyKey(nameof(CustomerByVisits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerByVisitsDayLimit = group.Add(new VocabularyKey(nameof(CustomerByVisitsDayLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerByVisitsNumLimit = group.Add(new VocabularyKey(nameof(CustomerByVisitsNumLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitAssortedProducts = group.Add(new VocabularyKey(nameof(LimitAssortedProducts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LimitAvailableCustomers = group.Add(new VocabularyKey(nameof(LimitAvailableCustomers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesAmountLimit = group.Add(new VocabularyKey(nameof(ProductSalesAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesAmountLimitDays = group.Add(new VocabularyKey(nameof(ProductSalesAmountLimitDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesQuantityLimit = group.Add(new VocabularyKey(nameof(ProductSalesQuantityLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSalesQuantityLimitDays = group.Add(new VocabularyKey(nameof(ProductSalesQuantityLimitDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsArrivalLimit = group.Add(new VocabularyKey(nameof(ProductsArrivalLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsArrivalLimitDays = group.Add(new VocabularyKey(nameof(ProductsArrivalLimitDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsByRecentArrival = group.Add(new VocabularyKey(nameof(ProductsByRecentArrival), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsBySalesAmount = group.Add(new VocabularyKey(nameof(ProductsBySalesAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsBySalesQuantity = group.Add(new VocabularyKey(nameof(ProductsBySalesQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductsBySpecificCategory = group.Add(new VocabularyKey(nameof(ProductsBySpecificCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrxUploadInterval = group.Add(new VocabularyKey(nameof(TrxUploadInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DirAddressBook_Name = group.Add(new VocabularyKey(nameof(DirAddressBook_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailAssortmentTable_AssortmentID = group.Add(new VocabularyKey(nameof(RetailAssortmentTable_AssortmentID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PromptOnSeamlessOffline = group.Add(new VocabularyKey(nameof(PromptOnSeamlessOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetryCountToOffline = group.Add(new VocabularyKey(nameof(RetryCountToOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowManualOfflineBeforeSignIn = group.Add(new VocabularyKey(nameof(AllowManualOfflineBeforeSignIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableAdvancedOfflineSwitching = group.Add(new VocabularyKey(nameof(EnableAdvancedOfflineSwitching), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemHealthCheckInterval = group.Add(new VocabularyKey(nameof(SystemHealthCheckInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PauseOfflineSync = group.Add(new VocabularyKey(nameof(PauseOfflineSync), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AddressBook { get; private set; }
        public VocabularyKey Assortment { get; private set; }
        public VocabularyKey CheckNewDBInterval { get; private set; }
        public VocabularyKey DBExportPath { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ImagePath { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey UploadTransactionSize { get; private set; }
        public VocabularyKey ReconnectInterval { get; private set; }
        public VocabularyKey Timeout { get; private set; }
        public VocabularyKey CustomerByAddress { get; private set; }
        public VocabularyKey CustomerBySalesAmount { get; private set; }
        public VocabularyKey CustomerBySalesAmountDayLimit { get; private set; }
        public VocabularyKey CustomerBySalesAmountNumLimit { get; private set; }
        public VocabularyKey CustomerByVisits { get; private set; }
        public VocabularyKey CustomerByVisitsDayLimit { get; private set; }
        public VocabularyKey CustomerByVisitsNumLimit { get; private set; }
        public VocabularyKey LimitAssortedProducts { get; private set; }
        public VocabularyKey LimitAvailableCustomers { get; private set; }
        public VocabularyKey ProductSalesAmountLimit { get; private set; }
        public VocabularyKey ProductSalesAmountLimitDays { get; private set; }
        public VocabularyKey ProductSalesQuantityLimit { get; private set; }
        public VocabularyKey ProductSalesQuantityLimitDays { get; private set; }
        public VocabularyKey ProductsArrivalLimit { get; private set; }
        public VocabularyKey ProductsArrivalLimitDays { get; private set; }
        public VocabularyKey ProductsByRecentArrival { get; private set; }
        public VocabularyKey ProductsBySalesAmount { get; private set; }
        public VocabularyKey ProductsBySalesQuantity { get; private set; }
        public VocabularyKey ProductsBySpecificCategory { get; private set; }
        public VocabularyKey TrxUploadInterval { get; private set; }
        public VocabularyKey DirAddressBook_Name { get; private set; }
        public VocabularyKey RetailAssortmentTable_AssortmentID { get; private set; }
        public VocabularyKey PromptOnSeamlessOffline { get; private set; }
        public VocabularyKey RetryCountToOffline { get; private set; }
        public VocabularyKey AllowManualOfflineBeforeSignIn { get; private set; }
        public VocabularyKey EnableAdvancedOfflineSwitching { get; private set; }
        public VocabularyKey SystemHealthCheckInterval { get; private set; }
        public VocabularyKey PauseOfflineSync { get; private set; }


    }
}