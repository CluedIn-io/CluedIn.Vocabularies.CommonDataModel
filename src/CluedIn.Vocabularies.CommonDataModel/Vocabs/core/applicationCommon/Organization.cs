using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OrganizationVocabulary : SimpleVocabulary
    {
        public OrganizationVocabulary()
        {
            VocabularyName = "Organization";
            KeyPrefix = "commonDataModel.organization";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Organization;

            AddGroup("Organization Details for ApplicationCommon", group =>
            {
                OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Organization Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), "User Group", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PrivilegeUserGroupId = group.Add(new VocabularyKey(nameof(PrivilegeUserGroupId), "Privilege User Group", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                RecurrenceExpansionJobBatchSize = group.Add(new VocabularyKey(nameof(RecurrenceExpansionJobBatchSize), "Recurrence Expansion On Demand Job Batch Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RecurrenceExpansionJobBatchInterval = group.Add(new VocabularyKey(nameof(RecurrenceExpansionJobBatchInterval), "Recurrence Expansion Job Batch Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FiscalPeriodType = group.Add(new VocabularyKey(nameof(FiscalPeriodType), "Fiscal Period Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FiscalCalendarStart = group.Add(new VocabularyKey(nameof(FiscalCalendarStart), "Fiscal Calendar Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateFormatCode = group.Add(new VocabularyKey(nameof(DateFormatCode), "Date Format Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeFormatCode = group.Add(new VocabularyKey(nameof(TimeFormatCode), "Time Format Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencySymbol = group.Add(new VocabularyKey(nameof(CurrencySymbol), "Currency Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeekStartDayCode = group.Add(new VocabularyKey(nameof(WeekStartDayCode), "Week Start Day Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateSeparator = group.Add(new VocabularyKey(nameof(DateSeparator), "Date Separator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullNameConventionCode = group.Add(new VocabularyKey(nameof(FullNameConventionCode), "Full Name Display Order", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NegativeFormatCode = group.Add(new VocabularyKey(nameof(NegativeFormatCode), "Negative Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberFormat = group.Add(new VocabularyKey(nameof(NumberFormat), "Number Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), "Is Organization Disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DisabledReason = group.Add(new VocabularyKey(nameof(DisabledReason), "Disabled Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KbPrefix = group.Add(new VocabularyKey(nameof(KbPrefix), "Article Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentKbNumber = group.Add(new VocabularyKey(nameof(CurrentKbNumber), "Current Article Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CasePrefix = group.Add(new VocabularyKey(nameof(CasePrefix), "Case Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentCaseNumber = group.Add(new VocabularyKey(nameof(CurrentCaseNumber), "Current Case Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ContractPrefix = group.Add(new VocabularyKey(nameof(ContractPrefix), "Contract Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentContractNumber = group.Add(new VocabularyKey(nameof(CurrentContractNumber), "Current Contract Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                QuotePrefix = group.Add(new VocabularyKey(nameof(QuotePrefix), "Quote Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentQuoteNumber = group.Add(new VocabularyKey(nameof(CurrentQuoteNumber), "Current Quote Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OrderPrefix = group.Add(new VocabularyKey(nameof(OrderPrefix), "Order Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentOrderNumber = group.Add(new VocabularyKey(nameof(CurrentOrderNumber), "Current Order Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                InvoicePrefix = group.Add(new VocabularyKey(nameof(InvoicePrefix), "Invoice Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentInvoiceNumber = group.Add(new VocabularyKey(nameof(CurrentInvoiceNumber), "Current Invoice Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UniqueSpecifierLength = group.Add(new VocabularyKey(nameof(UniqueSpecifierLength), "Unique String Length", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalYearFormat = group.Add(new VocabularyKey(nameof(FiscalYearFormat), "Fiscal Year Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPeriodFormat = group.Add(new VocabularyKey(nameof(FiscalPeriodFormat), "Fiscal Period Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalYearPeriodConnect = group.Add(new VocabularyKey(nameof(FiscalYearPeriodConnect), "Fiscal Year Period Connector", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageCode = group.Add(new VocabularyKey(nameof(LanguageCode), "Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortId = group.Add(new VocabularyKey(nameof(SortId), "Sort", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DateFormatString = group.Add(new VocabularyKey(nameof(DateFormatString), "Date Format String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeFormatString = group.Add(new VocabularyKey(nameof(TimeFormatString), "Time Format String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingDecimalPrecision = group.Add(new VocabularyKey(nameof(PricingDecimalPrecision), "Pricing Decimal Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ShowWeekNumber = group.Add(new VocabularyKey(nameof(ShowWeekNumber), "Show Week Number", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                NextTrackingNumber = group.Add(new VocabularyKey(nameof(NextTrackingNumber), "Next Tracking Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TagMaxAggressiveCycles = group.Add(new VocabularyKey(nameof(TagMaxAggressiveCycles), "Auto-Tag Max Cycles", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemUserId = group.Add(new VocabularyKey(nameof(SystemUserId), "System User", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                GrantAccessToNetworkService = group.Add(new VocabularyKey(nameof(GrantAccessToNetworkService), "Grant Access To Network Service", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowOutlookScheduledSyncs = group.Add(new VocabularyKey(nameof(AllowOutlookScheduledSyncs), "Allow Scheduled Synchronization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowMarketingEmailExecution = group.Add(new VocabularyKey(nameof(AllowMarketingEmailExecution), "Allow Marketing Email Execution", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SqlAccessGroupId = group.Add(new VocabularyKey(nameof(SqlAccessGroupId), "SQL Access Group", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CurrencyFormatCode = group.Add(new VocabularyKey(nameof(CurrencyFormatCode), "Currency Format Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalSettingsUpdated = group.Add(new VocabularyKey(nameof(FiscalSettingsUpdated), "Is Fiscal Settings Updated", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ReportingGroupId = group.Add(new VocabularyKey(nameof(ReportingGroupId), "Reporting Group", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TokenExpiry = group.Add(new VocabularyKey(nameof(TokenExpiry), "Token Expiration Duration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShareToPreviousOwnerOnAssign = group.Add(new VocabularyKey(nameof(ShareToPreviousOwnerOnAssign), "Share To Previous Owner On Assign", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AcknowledgementTemplateId = group.Add(new VocabularyKey(nameof(AcknowledgementTemplateId), "Acknowledgement Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationUserId = group.Add(new VocabularyKey(nameof(IntegrationUserId), "Integration User", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TrackingTokenIdBase = group.Add(new VocabularyKey(nameof(TrackingTokenIdBase), "Tracking Token Base", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                BusinessClosureCalendarId = group.Add(new VocabularyKey(nameof(BusinessClosureCalendarId), "Business Closure Calendar", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                AllowAutoUnsubscribeAcknowledgement = group.Add(new VocabularyKey(nameof(AllowAutoUnsubscribeAcknowledgement), "Allow Automatic Unsubscribe Acknowledgement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowAutoUnsubscribe = group.Add(new VocabularyKey(nameof(AllowAutoUnsubscribe), "Allow Automatic Unsubscribe", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                Picture = group.Add(new VocabularyKey(nameof(Picture), "Picture", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrackingPrefix = group.Add(new VocabularyKey(nameof(TrackingPrefix), "Tracking Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinOutlookSyncInterval = group.Add(new VocabularyKey(nameof(MinOutlookSyncInterval), "Min Synchronization Frequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                BulkOperationPrefix = group.Add(new VocabularyKey(nameof(BulkOperationPrefix), "Bulk Operation Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowAutoResponseCreation = group.Add(new VocabularyKey(nameof(AllowAutoResponseCreation), "Allow Automatic Response Creation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaximumTrackingNumber = group.Add(new VocabularyKey(nameof(MaximumTrackingNumber), "Max Tracking Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CampaignPrefix = group.Add(new VocabularyKey(nameof(CampaignPrefix), "Campaign Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SqlAccessGroupName = group.Add(new VocabularyKey(nameof(SqlAccessGroupName), "SQL Access Group Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentCampaignNumber = group.Add(new VocabularyKey(nameof(CurrentCampaignNumber), "Current Campaign Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FiscalYearDisplayCode = group.Add(new VocabularyKey(nameof(FiscalYearDisplayCode), "Fiscal Year Display", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteMapXml = group.Add(new VocabularyKey(nameof(SiteMapXml), "SiteMap XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRegistered = group.Add(new VocabularyKey(nameof(IsRegistered), "Is Registered", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ReportingGroupName = group.Add(new VocabularyKey(nameof(ReportingGroupName), "Reporting Group Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentBulkOperationNumber = group.Add(new VocabularyKey(nameof(CurrentBulkOperationNumber), "Current Bulk Operation Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SchemaNamePrefix = group.Add(new VocabularyKey(nameof(SchemaNamePrefix), "Customization Name Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreInternalEmail = group.Add(new VocabularyKey(nameof(IgnoreInternalEmail), "Ignore Internal Email", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                TagPollingPeriod = group.Add(new VocabularyKey(nameof(TagPollingPeriod), "Auto-Tag Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TrackingTokenIdDigits = group.Add(new VocabularyKey(nameof(TrackingTokenIdDigits), "Tracking Token Digits", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberGroupFormat = group.Add(new VocabularyKey(nameof(NumberGroupFormat), "Number Grouping Format", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LongDateFormatCode = group.Add(new VocabularyKey(nameof(LongDateFormatCode), "Long Date Format", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CurrentImportSequenceNumber = group.Add(new VocabularyKey(nameof(CurrentImportSequenceNumber), "Current Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ParsedTablePrefix = group.Add(new VocabularyKey(nameof(ParsedTablePrefix), "Parsed Table Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                V3CalloutConfigHash = group.Add(new VocabularyKey(nameof(V3CalloutConfigHash), "V3 Callout Hash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFiscalPeriodMonthBased = group.Add(new VocabularyKey(nameof(IsFiscalPeriodMonthBased), "Is Fiscal Period Monthly", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LocaleId = group.Add(new VocabularyKey(nameof(LocaleId), "Locale", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParsedTableColumnPrefix = group.Add(new VocabularyKey(nameof(ParsedTableColumnPrefix), "Parsed Table Column Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SupportUserId = group.Add(new VocabularyKey(nameof(SupportUserId), "Support User", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                AMDesignator = group.Add(new VocabularyKey(nameof(AMDesignator), "AM Designator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyDisplayOption = group.Add(new VocabularyKey(nameof(CurrencyDisplayOption), "Display Currencies Using", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinAddressBookSyncInterval = group.Add(new VocabularyKey(nameof(MinAddressBookSyncInterval), "Min Address Synchronization Frequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsDuplicateDetectionEnabledForOnlineCreateUpdate = group.Add(new VocabularyKey(nameof(IsDuplicateDetectionEnabledForOnlineCreateUpdate), "Is Duplicate Detection Enabled for Online Create/Update", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                FeatureSet = group.Add(new VocabularyKey(nameof(FeatureSet), "Feature Set", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedAttachments = group.Add(new VocabularyKey(nameof(BlockedAttachments), "Block Attachments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDuplicateDetectionEnabledForOfflineSync = group.Add(new VocabularyKey(nameof(IsDuplicateDetectionEnabledForOfflineSync), "Is Duplicate Detection Enabled For Offline Synchronization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowOfflineScheduledSyncs = group.Add(new VocabularyKey(nameof(AllowOfflineScheduledSyncs), "Allow Offline Scheduled Synchronization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowUnresolvedPartiesOnEmailSend = group.Add(new VocabularyKey(nameof(AllowUnresolvedPartiesOnEmailSend), "Allow Unresolved Address Email Send", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                TimeSeparator = group.Add(new VocabularyKey(nameof(TimeSeparator), "Time Separator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentParsedTableNumber = group.Add(new VocabularyKey(nameof(CurrentParsedTableNumber), "Current Parsed Table Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MinOfflineSyncInterval = group.Add(new VocabularyKey(nameof(MinOfflineSyncInterval), "Min Offline Synchronization Frequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AllowWebExcelExport = group.Add(new VocabularyKey(nameof(AllowWebExcelExport), "Allow Export to Excel", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ReferenceSiteMapXml = group.Add(new VocabularyKey(nameof(ReferenceSiteMapXml), "Reference SiteMap XML", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDuplicateDetectionEnabledForImport = group.Add(new VocabularyKey(nameof(IsDuplicateDetectionEnabledForImport), "Is Duplicate Detection Enabled For Import", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                CalendarType = group.Add(new VocabularyKey(nameof(CalendarType), "Calendar Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SQMEnabled = group.Add(new VocabularyKey(nameof(SQMEnabled), "Is SQM Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                NegativeCurrencyFormatCode = group.Add(new VocabularyKey(nameof(NegativeCurrencyFormatCode), "Negative Currency Format", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AllowAddressBookSyncs = group.Add(new VocabularyKey(nameof(AllowAddressBookSyncs), "Allow Address Book Synchronization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ISVIntegrationCode = group.Add(new VocabularyKey(nameof(ISVIntegrationCode), "ISV Integration Mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DecimalSymbol = group.Add(new VocabularyKey(nameof(DecimalSymbol), "Decimal Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxUploadFileSize = group.Add(new VocabularyKey(nameof(MaxUploadFileSize), "Max Upload File Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsAppMode = group.Add(new VocabularyKey(nameof(IsAppMode), "Is Application Mode Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                EnablePricingOnCreate = group.Add(new VocabularyKey(nameof(EnablePricingOnCreate), "Enable Pricing On Create", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsSOPIntegrationEnabled = group.Add(new VocabularyKey(nameof(IsSOPIntegrationEnabled), "Is Sales Order Integration Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PMDesignator = group.Add(new VocabularyKey(nameof(PMDesignator), "PM Designator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyDecimalPrecision = group.Add(new VocabularyKey(nameof(CurrencyDecimalPrecision), "Currency Decimal Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxAppointmentDurationDays = group.Add(new VocabularyKey(nameof(MaxAppointmentDurationDays), "Max Appointment Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EmailSendPollingPeriod = group.Add(new VocabularyKey(nameof(EmailSendPollingPeriod), "Email Send Polling Frequency", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RenderSecureIFrameForEmail = group.Add(new VocabularyKey(nameof(RenderSecureIFrameForEmail), "Render Secure Frame For Email", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                NumberSeparator = group.Add(new VocabularyKey(nameof(NumberSeparator), "Number Separator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrivReportingGroupId = group.Add(new VocabularyKey(nameof(PrivReportingGroupId), "Privilege Reporting Group", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                MaxRecordsForExportToExcel = group.Add(new VocabularyKey(nameof(MaxRecordsForExportToExcel), "Max Records For Excel Export", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PrivReportingGroupName = group.Add(new VocabularyKey(nameof(PrivReportingGroupName), "Privilege Reporting Group Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearStartWeekCode = group.Add(new VocabularyKey(nameof(YearStartWeekCode), "Year Start Week Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsPresenceEnabled = group.Add(new VocabularyKey(nameof(IsPresenceEnabled), "Presence Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsDuplicateDetectionEnabled = group.Add(new VocabularyKey(nameof(IsDuplicateDetectionEnabled), "Is Duplicate Detection Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExpireSubscriptionsInDays = group.Add(new VocabularyKey(nameof(ExpireSubscriptionsInDays), "Days to Expire Subscriptions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsAuditEnabled = group.Add(new VocabularyKey(nameof(IsAuditEnabled), "Is Auditing Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                BaseCurrencyPrecision = group.Add(new VocabularyKey(nameof(BaseCurrencyPrecision), "Base Currency Precision", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                BaseCurrencySymbol = group.Add(new VocabularyKey(nameof(BaseCurrencySymbol), "Base Currency Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxRecordsForLookupFilters = group.Add(new VocabularyKey(nameof(MaxRecordsForLookupFilters), "Max Records Filter Selection", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AllowEntityOnlyAudit = group.Add(new VocabularyKey(nameof(AllowEntityOnlyAudit), "Allow Entity Level Auditing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultRecurrenceEndRangeType = group.Add(new VocabularyKey(nameof(DefaultRecurrenceEndRangeType), "Default Recurrence End Range Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FutureExpansionWindow = group.Add(new VocabularyKey(nameof(FutureExpansionWindow), "Future Expansion Window", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PastExpansionWindow = group.Add(new VocabularyKey(nameof(PastExpansionWindow), "Past Expansion Window", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RecurrenceExpansionSynchCreateMax = group.Add(new VocabularyKey(nameof(RecurrenceExpansionSynchCreateMax), "Recurrence Expansion Synchronization Create Maximum", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                RecurrenceDefaultNumberOfOccurrences = group.Add(new VocabularyKey(nameof(RecurrenceDefaultNumberOfOccurrences), "Recurrence Default Number of Occurrences", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                GetStartedPaneContentEnabled = group.Add(new VocabularyKey(nameof(GetStartedPaneContentEnabled), "Is Get Started Pane Content Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                UseReadForm = group.Add(new VocabularyKey(nameof(UseReadForm), "Use Read-Optimized Form", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                InitialVersion = group.Add(new VocabularyKey(nameof(InitialVersion), "Initial Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SampleDataImportId = group.Add(new VocabularyKey(nameof(SampleDataImportId), "Sample Data Import", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ReportScriptErrors = group.Add(new VocabularyKey(nameof(ReportScriptErrors), "Report Script Errors", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireApprovalForUserEmail = group.Add(new VocabularyKey(nameof(RequireApprovalForUserEmail), "Is Approval For User Email Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                RequireApprovalForQueueEmail = group.Add(new VocabularyKey(nameof(RequireApprovalForQueueEmail), "Is Approval For Queue Email Required", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                GoalRollupExpiryTime = group.Add(new VocabularyKey(nameof(GoalRollupExpiryTime), "Rollup Expiration Time for Goal", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                GoalRollupFrequency = group.Add(new VocabularyKey(nameof(GoalRollupFrequency), "Automatic Rollup Frequency for Goal", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AutoApplyDefaultonCaseCreate = group.Add(new VocabularyKey(nameof(AutoApplyDefaultonCaseCreate), "Auto Apply Default Entitlement on Case Create", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AutoApplyDefaultonCaseUpdate = group.Add(new VocabularyKey(nameof(AutoApplyDefaultonCaseUpdate), "Auto Apply Default Entitlement on Case Update", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                FiscalYearFormatPrefix = group.Add(new VocabularyKey(nameof(FiscalYearFormatPrefix), "Prefix for Fiscal Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalYearFormatSuffix = group.Add(new VocabularyKey(nameof(FiscalYearFormatSuffix), "Suffix for Fiscal Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalYearFormatYear = group.Add(new VocabularyKey(nameof(FiscalYearFormatYear), "Fiscal Year Format Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCalculationMethod = group.Add(new VocabularyKey(nameof(DiscountCalculationMethod), "Discount calculation method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPeriodFormatPeriod = group.Add(new VocabularyKey(nameof(FiscalPeriodFormatPeriod), "Format for Fiscal Period", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowClientMessageBarAd = group.Add(new VocabularyKey(nameof(AllowClientMessageBarAd), "Allow Outlook Client Message Bar Advertisement", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowUserFormModePreference = group.Add(new VocabularyKey(nameof(AllowUserFormModePreference), "Allow User Form Mode Preference", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                HashFilterKeywords = group.Add(new VocabularyKey(nameof(HashFilterKeywords), "Hash Filter Keywords", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HashMaxCount = group.Add(new VocabularyKey(nameof(HashMaxCount), "Hash Max Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                HashDeltaSubjectCount = group.Add(new VocabularyKey(nameof(HashDeltaSubjectCount), "Hash Delta Subject Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                HashMinAddressCount = group.Add(new VocabularyKey(nameof(HashMinAddressCount), "Hash Min Address Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EnableSmartMatching = group.Add(new VocabularyKey(nameof(EnableSmartMatching), "Enable Smart Matching", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PinpointLanguageCode = group.Add(new VocabularyKey(nameof(PinpointLanguageCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrgDbOrgSettings = group.Add(new VocabularyKey(nameof(OrgDbOrgSettings), "Organization Database Organization Settings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsUserAccessAuditEnabled = group.Add(new VocabularyKey(nameof(IsUserAccessAuditEnabled), "Is User Access Auditing Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                UserAccessAuditingInterval = group.Add(new VocabularyKey(nameof(UserAccessAuditingInterval), "User Authentication Auditing Interval", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                QuickFindRecordLimitEnabled = group.Add(new VocabularyKey(nameof(QuickFindRecordLimitEnabled), "Quick Find Record Limit Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                EnableBingMapsIntegration = group.Add(new VocabularyKey(nameof(EnableBingMapsIntegration), "Enable Integration with Bing Maps", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsDefaultCountryCodeCheckEnabled = group.Add(new VocabularyKey(nameof(IsDefaultCountryCodeCheckEnabled), "Enable or disable country code selection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultCountryCode = group.Add(new VocabularyKey(nameof(DefaultCountryCode), "Default Country Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSkypeProtocol = group.Add(new VocabularyKey(nameof(UseSkypeProtocol), "User Skype Protocol", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IncomingEmailExchangeEmailRetrievalBatchSize = group.Add(new VocabularyKey(nameof(IncomingEmailExchangeEmailRetrievalBatchSize), "Exchange Email Retrieval Batch Size", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EmailCorrelationEnabled = group.Add(new VocabularyKey(nameof(EmailCorrelationEnabled), "Use Email Correlation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                YammerOAuthAccessTokenExpired = group.Add(new VocabularyKey(nameof(YammerOAuthAccessTokenExpired), "Yammer OAuth Access Token Expired", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultEmailSettings = group.Add(new VocabularyKey(nameof(DefaultEmailSettings), "Default Email Settings", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible));
                YammerGroupId = group.Add(new VocabularyKey(nameof(YammerGroupId), "Yammer Group Id", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                YammerNetworkPermalink = group.Add(new VocabularyKey(nameof(YammerNetworkPermalink), "Yammer Network Permalink", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YammerPostMethod = group.Add(new VocabularyKey(nameof(YammerPostMethod), "Internal Use Only", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmailConnectionChannel = group.Add(new VocabularyKey(nameof(EmailConnectionChannel), "Email Connection Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultEmailServerProfileId = group.Add(new VocabularyKey(nameof(DefaultEmailServerProfileId), "Email Server Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAutoSaveEnabled = group.Add(new VocabularyKey(nameof(IsAutoSaveEnabled), "Auto Save Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                BingMapsApiKey = group.Add(new VocabularyKey(nameof(BingMapsApiKey), "Bing Maps API Key", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GenerateAlertsForErrors = group.Add(new VocabularyKey(nameof(GenerateAlertsForErrors), "Generate Alerts For Errors", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                GenerateAlertsForInformation = group.Add(new VocabularyKey(nameof(GenerateAlertsForInformation), "Generate Alerts For Information", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                GenerateAlertsForWarnings = group.Add(new VocabularyKey(nameof(GenerateAlertsForWarnings), "Generate Alerts For Warnings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                NotifyMailboxOwnerOfEmailServerLevelAlerts = group.Add(new VocabularyKey(nameof(NotifyMailboxOwnerOfEmailServerLevelAlerts), "Notify Mailbox Owner Of Email Server Level Alerts", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaximumActiveBusinessProcessFlowsAllowedPerEntity = group.Add(new VocabularyKey(nameof(MaximumActiveBusinessProcessFlowsAllowedPerEntity), "Maximum active business process flows per entity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), "Entity Image Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                AllowUsersSeeAppdownloadMessage = group.Add(new VocabularyKey(nameof(AllowUsersSeeAppdownloadMessage), "Allow the showing tablet application notification bars in a browser.", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SignupOutlookDownloadFWLink = group.Add(new VocabularyKey(nameof(SignupOutlookDownloadFWLink), "CRMForOutlookDownloadURL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CascadeStatusUpdate = group.Add(new VocabularyKey(nameof(CascadeStatusUpdate), "Cascade Status Update", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                RestrictStatusUpdate = group.Add(new VocabularyKey(nameof(RestrictStatusUpdate), "Restrict Status Update", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SuppressSLA = group.Add(new VocabularyKey(nameof(SuppressSLA), "Is SLA suppressed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SocialInsightsTermsAccepted = group.Add(new VocabularyKey(nameof(SocialInsightsTermsAccepted), "Social Insights Terms of Use", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SocialInsightsInstance = group.Add(new VocabularyKey(nameof(SocialInsightsInstance), "Social Insights instance identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisableSocialCare = group.Add(new VocabularyKey(nameof(DisableSocialCare), "Is Social Care disabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaxProductsInBundle = group.Add(new VocabularyKey(nameof(MaxProductsInBundle), "Bundle Item Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UseInbuiltRuleForDefaultPricelistSelection = group.Add(new VocabularyKey(nameof(UseInbuiltRuleForDefaultPricelistSelection), "Use Inbuilt Rule For Default Pricelist Selection", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                OOBPriceCalculationEnabled = group.Add(new VocabularyKey(nameof(OOBPriceCalculationEnabled), "Enable OOB Price calculation", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsHierarchicalSecurityModelEnabled = group.Add(new VocabularyKey(nameof(IsHierarchicalSecurityModelEnabled), "Enable Hierarchical Security Model", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaximumDynamicPropertiesAllowed = group.Add(new VocabularyKey(nameof(MaximumDynamicPropertiesAllowed), "Product Properties Item Limit", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UsePositionHierarchy = group.Add(new VocabularyKey(nameof(UsePositionHierarchy), "Use position hierarchy", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaxDepthForHierarchicalSecurityModel = group.Add(new VocabularyKey(nameof(MaxDepthForHierarchicalSecurityModel), "Maximum depth for hierarchy security propagation.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SlaPauseStates = group.Add(new VocabularyKey(nameof(SlaPauseStates), "SLA pause states", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SocialInsightsEnabled = group.Add(new VocabularyKey(nameof(SocialInsightsEnabled), "Social Insights Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsAppointmentAttachmentSyncEnabled = group.Add(new VocabularyKey(nameof(IsAppointmentAttachmentSyncEnabled), "Is Attachment Sync Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsAssignedTasksSyncEnabled = group.Add(new VocabularyKey(nameof(IsAssignedTasksSyncEnabled), "Is Assigned Tasks Sync Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsContactMailingAddressSyncEnabled = group.Add(new VocabularyKey(nameof(IsContactMailingAddressSyncEnabled), "Is Mailing Address Sync Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaxSupportedInternetExplorerVersion = group.Add(new VocabularyKey(nameof(MaxSupportedInternetExplorerVersion), "Max supported IE version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                GlobalHelpUrl = group.Add(new VocabularyKey(nameof(GlobalHelpUrl), "Global Help URL.", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                GlobalHelpUrlEnabled = group.Add(new VocabularyKey(nameof(GlobalHelpUrlEnabled), "Is Customizable Global Help enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                GlobalAppendUrlParametersEnabled = group.Add(new VocabularyKey(nameof(GlobalAppendUrlParametersEnabled), "Is AppendUrl Parameters enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                KMSettings = group.Add(new VocabularyKey(nameof(KMSettings), "Knowledge Management Settings", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateProductsWithoutParentInActiveState = group.Add(new VocabularyKey(nameof(CreateProductsWithoutParentInActiveState), "Enable Active Initial Product State", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsMailboxInactiveBackoffEnabled = group.Add(new VocabularyKey(nameof(IsMailboxInactiveBackoffEnabled), "Is Mailbox Keep Alive Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsFullTextSearchEnabled = group.Add(new VocabularyKey(nameof(IsFullTextSearchEnabled), "Enable Full-text search for Quick Find", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                EnforceReadOnlyPlugins = group.Add(new VocabularyKey(nameof(EnforceReadOnlyPlugins), "Organization setting to enforce read only plugins.", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SharePointDeploymentType = group.Add(new VocabularyKey(nameof(SharePointDeploymentType), "Choose SharePoint Deployment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationState = group.Add(new VocabularyKey(nameof(OrganizationState), "Organization State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultThemeData = group.Add(new VocabularyKey(nameof(DefaultThemeData), "Default Theme Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFolderBasedTrackingEnabled = group.Add(new VocabularyKey(nameof(IsFolderBasedTrackingEnabled), "Is Folder Based Tracking Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                WebResourceHash = group.Add(new VocabularyKey(nameof(WebResourceHash), "Web resource hash", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpireChangeTrackingInDays = group.Add(new VocabularyKey(nameof(ExpireChangeTrackingInDays), "Days to Expire Change Tracking Deleted Records", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxFolderBasedTrackingMappings = group.Add(new VocabularyKey(nameof(MaxFolderBasedTrackingMappings), "Max Folder Based Tracking Mappings", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PrivacyStatementUrl = group.Add(new VocabularyKey(nameof(PrivacyStatementUrl), "Privacy Statement URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                PluginTraceLogSetting = group.Add(new VocabularyKey(nameof(PluginTraceLogSetting), "Plug-in Trace Log Setting", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMailboxForcedUnlockingEnabled = group.Add(new VocabularyKey(nameof(IsMailboxForcedUnlockingEnabled), "Is Mailbox Forced Unlocking Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MailboxIntermittentIssueMinRange = group.Add(new VocabularyKey(nameof(MailboxIntermittentIssueMinRange), "Lower Threshold For Mailbox Intermittent Issue", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MailboxPermanentIssueMinRange = group.Add(new VocabularyKey(nameof(MailboxPermanentIssueMinRange), "Lower Threshold For Mailbox Permanent Issue.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                HighContrastThemeData = group.Add(new VocabularyKey(nameof(HighContrastThemeData), "High contrast Theme Data", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelegatedAdminUserId = group.Add(new VocabularyKey(nameof(DelegatedAdminUserId), "Delegated Admin", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                IsExternalSearchIndexEnabled = group.Add(new VocabularyKey(nameof(IsExternalSearchIndexEnabled), "Enable external search data syncing", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsMobileOfflineEnabled = group.Add(new VocabularyKey(nameof(IsMobileOfflineEnabled), "Enable MobileOffline for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsOfficeGraphEnabled = group.Add(new VocabularyKey(nameof(IsOfficeGraphEnabled), "Enable OfficeGraph for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsOneDriveEnabled = group.Add(new VocabularyKey(nameof(IsOneDriveEnabled), "Enable One Drive for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExternalPartyEntitySettings = group.Add(new VocabularyKey(nameof(ExternalPartyEntitySettings), "ExternalPartyEnabled Entities Settings.For internal use only", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalPartyCorrelationKeys = group.Add(new VocabularyKey(nameof(ExternalPartyCorrelationKeys), "ExternalPartyEnabled Entities correlation Keys", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxVerboseLoggingMailbox = group.Add(new VocabularyKey(nameof(MaxVerboseLoggingMailbox), "Max No Of Mailboxes To Enable For Verbose Logging", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaxVerboseLoggingSyncCycles = group.Add(new VocabularyKey(nameof(MaxVerboseLoggingSyncCycles), "Maximum number of sync cycles for which verbose logging will be enabled by default", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MobileOfflineSyncInterval = group.Add(new VocabularyKey(nameof(MobileOfflineSyncInterval), "Sync interval for mobile offline.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OfficeGraphDelveUrl = group.Add(new VocabularyKey(nameof(OfficeGraphDelveUrl), "The url to open the Delve", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                MobileOfflineMinLicenseTrial = group.Add(new VocabularyKey(nameof(MobileOfflineMinLicenseTrial), "Minimum number of user license required for mobile offline service by trial organization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MobileOfflineMinLicenseProd = group.Add(new VocabularyKey(nameof(MobileOfflineMinLicenseProd), "Minimum number of user license required for mobile offline service by production/preview organization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                DaysSinceRecordLastModifiedMaxValue = group.Add(new VocabularyKey(nameof(DaysSinceRecordLastModifiedMaxValue), "Max value of Days since record last modified", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                TaskBasedFlowEnabled = group.Add(new VocabularyKey(nameof(TaskBasedFlowEnabled), "Enable Task Flow processes for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ShowKBArticleDeprecationNotification = group.Add(new VocabularyKey(nameof(ShowKBArticleDeprecationNotification), "Show KBArticle deprecation message to user", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AzureSchedulerJobCollectionName = group.Add(new VocabularyKey(nameof(AzureSchedulerJobCollectionName), "For internal use only.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CortanaProactiveExperienceEnabled = group.Add(new VocabularyKey(nameof(CortanaProactiveExperienceEnabled), "Enable Cortana Proactive Experience Flow processes for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                OfficeAppsAutoDeploymentEnabled = group.Add(new VocabularyKey(nameof(OfficeAppsAutoDeploymentEnabled), "Enable Office Apps Auto Deployment for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AppDesignerExperienceEnabled = group.Add(new VocabularyKey(nameof(AppDesignerExperienceEnabled), "Enable App Designer Experience for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                EnableImmersiveSkypeIntegration = group.Add(new VocabularyKey(nameof(EnableImmersiveSkypeIntegration), "Enable Integration with Immersive Skype", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AutoApplySLA = group.Add(new VocabularyKey(nameof(AutoApplySLA), "Is Auto-apply SLA After Manually Over-riding", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsEmailServerProfileContentFilteringEnabled = group.Add(new VocabularyKey(nameof(IsEmailServerProfileContentFilteringEnabled), "Is Email Server Profile Content Filtering Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsDelegateAccessEnabled = group.Add(new VocabularyKey(nameof(IsDelegateAccessEnabled), "Is Delegation Access Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DisplayNavigationTour = group.Add(new VocabularyKey(nameof(DisplayNavigationTour), "Display Navigation Tour", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                UseLegacyRendering = group.Add(new VocabularyKey(nameof(UseLegacyRendering), "Legacy Form Rendering", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultMobileOfflineProfileId = group.Add(new VocabularyKey(nameof(DefaultMobileOfflineProfileId), "Default Mobile Offline Profile", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KaPrefix = group.Add(new VocabularyKey(nameof(KaPrefix), "Knowledge Article Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrentKaNumber = group.Add(new VocabularyKey(nameof(CurrentKaNumber), "Current Knowledge Article Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CurrentCategoryNumber = group.Add(new VocabularyKey(nameof(CurrentCategoryNumber), "Current Category Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CategoryPrefix = group.Add(new VocabularyKey(nameof(CategoryPrefix), "Category Prefix", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumEntitiesWithActiveSLA = group.Add(new VocabularyKey(nameof(MaximumEntitiesWithActiveSLA), "Maximum number of active SLA allowed per entity in online", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MaximumSLAKPIPerEntityWithActiveSLA = group.Add(new VocabularyKey(nameof(MaximumSLAKPIPerEntityWithActiveSLA), "Maximum number of active SLA KPI allowed per entity in online", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsConflictDetectionEnabledForMobileClient = group.Add(new VocabularyKey(nameof(IsConflictDetectionEnabledForMobileClient), "Is Conflict Detection for Mobile Client enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsDelveActionHubIntegrationEnabled = group.Add(new VocabularyKey(nameof(IsDelveActionHubIntegrationEnabled), "Enable Action Hub for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                OrgInsightsEnabled = group.Add(new VocabularyKey(nameof(OrgInsightsEnabled), "Enable OrgInsights for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ProductRecommendationsEnabled = group.Add(new VocabularyKey(nameof(ProductRecommendationsEnabled), "Enable Product Recommendations for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                TextAnalyticsEnabled = group.Add(new VocabularyKey(nameof(TextAnalyticsEnabled), "Enable Text Analytics for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaxConditionsForMobileOfflineFilters = group.Add(new VocabularyKey(nameof(MaxConditionsForMobileOfflineFilters), "Maximum number of conditions allowed for mobile offline filters", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                IsFolderAutoCreatedonSP = group.Add(new VocabularyKey(nameof(IsFolderAutoCreatedonSP), "Automatically create folders", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PowerBiFeatureEnabled = group.Add(new VocabularyKey(nameof(PowerBiFeatureEnabled), "Enable Power BI feature for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsActionCardEnabled = group.Add(new VocabularyKey(nameof(IsActionCardEnabled), "Enable Action Card for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsEmailMonitoringAllowed = group.Add(new VocabularyKey(nameof(IsEmailMonitoringAllowed), "Allow tracking recipient activity on sent emails", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsActivityAnalysisEnabled = group.Add(new VocabularyKey(nameof(IsActivityAnalysisEnabled), "Enable Relationship Analytics for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsAutoDataCaptureEnabled = group.Add(new VocabularyKey(nameof(IsAutoDataCaptureEnabled), "Enable Auto Capture for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ExternalBaseUrl = group.Add(new VocabularyKey(nameof(ExternalBaseUrl), "External Base URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                IsPreviewEnabledForActionCard = group.Add(new VocabularyKey(nameof(IsPreviewEnabledForActionCard), "Enable Preview Action Card feature for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsPreviewForEmailMonitoringAllowed = group.Add(new VocabularyKey(nameof(IsPreviewForEmailMonitoringAllowed), "Allows Preview For Email Monitoring", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                UnresolveEmailAddressIfMultipleMatch = group.Add(new VocabularyKey(nameof(UnresolveEmailAddressIfMultipleMatch), "Set To,cc,bcc fields as unresolved if multiple matches are found", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                RiErrorStatus = group.Add(new VocabularyKey(nameof(RiErrorStatus), "Error status of Relationship Insights provisioning.", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                WidgetProperties = group.Add(new VocabularyKey(nameof(WidgetProperties), "For Internal use only.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableMicrosoftFlowIntegration = group.Add(new VocabularyKey(nameof(EnableMicrosoftFlowIntegration), "Enable Integration with Microsoft Flow", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsEnabledForAllRoles = group.Add(new VocabularyKey(nameof(IsEnabledForAllRoles), "option set values for isenabledforallroles", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsPreviewForAutoCaptureEnabled = group.Add(new VocabularyKey(nameof(IsPreviewForAutoCaptureEnabled), "Enable Auto Capture for this Organization at Preview Settings", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                DefaultCrmCustomName = group.Add(new VocabularyKey(nameof(DefaultCrmCustomName), "Name of the default app", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ACIWebEndpointUrl = group.Add(new VocabularyKey(nameof(ACIWebEndpointUrl), "ACI Tenant URL.", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible));
                EnableLPAuthoring = group.Add(new VocabularyKey(nameof(EnableLPAuthoring), "Enable Learning Path Authoring", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsResourceBookingExchangeSyncEnabled = group.Add(new VocabularyKey(nameof(IsResourceBookingExchangeSyncEnabled), "Resource booking synchronization enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsMobileClientOnDemandSyncEnabled = group.Add(new VocabularyKey(nameof(IsMobileClientOnDemandSyncEnabled), "Is Mobile Client On Demand Sync enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                PostMessageWhitelistDomains = group.Add(new VocabularyKey(nameof(PostMessageWhitelistDomains), "For internal use only.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRelationshipInsightsEnabled = group.Add(new VocabularyKey(nameof(IsRelationshipInsightsEnabled), "Enable Relationship Insights for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ResolveSimilarUnresolvedEmailAddress = group.Add(new VocabularyKey(nameof(ResolveSimilarUnresolvedEmailAddress), "Apply same email address to all unresolved matches when you manually resolve it for one", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsTextWrapEnabled = group.Add(new VocabularyKey(nameof(IsTextWrapEnabled), "Enable Text Wrap", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SessionTimeoutEnabled = group.Add(new VocabularyKey(nameof(SessionTimeoutEnabled), "Session timeout enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SessionTimeoutInMins = group.Add(new VocabularyKey(nameof(SessionTimeoutInMins), "Session timeout in minutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SessionTimeoutReminderInMins = group.Add(new VocabularyKey(nameof(SessionTimeoutReminderInMins), "Session timeout reminder in minutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                MicrosoftFlowEnvironment = group.Add(new VocabularyKey(nameof(MicrosoftFlowEnvironment), "Environment selected for Integration with Microsoft Flow", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InactivityTimeoutEnabled = group.Add(new VocabularyKey(nameof(InactivityTimeoutEnabled), "Inactivity timeout enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                InactivityTimeoutInMins = group.Add(new VocabularyKey(nameof(InactivityTimeoutInMins), "Inactivity timeout in minutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                InactivityTimeoutReminderInMins = group.Add(new VocabularyKey(nameof(InactivityTimeoutReminderInMins), "Inactivity timeout reminder in minutes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SyncOptInSelection = group.Add(new VocabularyKey(nameof(SyncOptInSelection), "Enable dynamics 365 azure sync framework for this organization.", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                SyncOptInSelectionStatus = group.Add(new VocabularyKey(nameof(SyncOptInSelectionStatus), "Status of opt-in or opt-out operation for dynamics 365 azure sync.", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsActionSupportFeatureEnabled = group.Add(new VocabularyKey(nameof(IsActionSupportFeatureEnabled), "Action Support Feature enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsBPFEntityCustomizationFeatureEnabled = group.Add(new VocabularyKey(nameof(IsBPFEntityCustomizationFeatureEnabled), "BPF Entity Customization Feature enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                BoundDashboardDefaultCardExpanded = group.Add(new VocabularyKey(nameof(BoundDashboardDefaultCardExpanded), "Display cards in expanded state for Interactive Dashboard", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                MaxActionStepsInBPF = group.Add(new VocabularyKey(nameof(MaxActionStepsInBPF), "Maximum number of actionsteps allowed in a BPF", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ServeStaticResourcesFromAzureCDN = group.Add(new VocabularyKey(nameof(ServeStaticResourcesFromAzureCDN), "Serve Static Content From CDN", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsExternalFileStorageEnabled = group.Add(new VocabularyKey(nameof(IsExternalFileStorageEnabled), "Enable external file storage", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                ClientFeatureSet = group.Add(new VocabularyKey(nameof(ClientFeatureSet), "Client Feature Set", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReadAuditEnabled = group.Add(new VocabularyKey(nameof(IsReadAuditEnabled), "Is Read Auditing Enabled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsNotesAnalysisEnabled = group.Add(new VocabularyKey(nameof(IsNotesAnalysisEnabled), "Enable Notes Analysis for this Organization", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AllowLegacyDialogsEmbedding = group.Add(new VocabularyKey(nameof(AllowLegacyDialogsEmbedding), "Enable embedding of certain legacy dialogs in Unified Interface browser client", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                AppointmentRichEditorExperience = group.Add(new VocabularyKey(nameof(AppointmentRichEditorExperience), "Enable Rich Editing Experience for Appointment", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Organization Details for FoundationCommon", group =>
            {
                SchedulingEngine = group.Add(new VocabularyKey(nameof(SchedulingEngine), "Scheduling engine for Appointments and Service Activities", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("Organization Details for Scheduling", group =>
            {

            });

            #region Incoming Relationships
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="BaseCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="BaseCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="BaseCurrencyId"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="Currency"/> to Vocab 'Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwnerId"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningTeam"/> to Vocab 'Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="OrganizationId"/> from Vocab 'Article.cdm.json/Article' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'ArticleTemplate.cdm.json/ArticleTemplate' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'BusinessUnit.cdm.json/BusinessUnit' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'ConnectionRole.cdm.json/ConnectionRole' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Currency.cdm.json/Currency' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'GoalMetric.cdm.json/GoalMetric' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'KnowledgeBaseRecord.cdm.json/KnowledgeBaseRecord' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Position.cdm.json/Position' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Queue.cdm.json/Queue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'QueueItem.cdm.json/QueueItem' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Team.cdm.json/Team' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'Territory.cdm.json/Territory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'User.cdm.json/User' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/GrantApplicationBusinessProcessFlow.cdm.json/GrantApplicationBusinessProcessFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/InternshipApplicationFlow.cdm.json/InternshipApplicationFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/education/higherEducation/ScholarshipApplicationBusinessProcessFlow.cdm.json/ScholarshipApplicationBusinessProcessFlow' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionBodySite.cdm.json/ActivityDefinitionBodySite' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContact.cdm.json/ActivityDefinitionContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContributor.cdm.json/ActivityDefinitionContributor' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionContributorContact.cdm.json/ActivityDefinitionContributorContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionDosage.cdm.json/ActivityDefinitionDosage' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionDynamicValue.cdm.json/ActivityDefinitionDynamicValue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionJurisdiction.cdm.json/ActivityDefinitionJurisdiction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionLibrary.cdm.json/ActivityDefinitionLibrary' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionParticipant.cdm.json/ActivityDefinitionParticipant' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionRelatedArtifact.cdm.json/ActivityDefinitionRelatedArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionTopic.cdm.json/ActivityDefinitionTopic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinitionUseContext.cdm.json/ActivityDefinitionUseContext' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/CodeableConcept.cdm.json/CodeableConcept' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirement.cdm.json/DataRequirement' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilter.cdm.json/DataRequirementCodeFilter' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilterValueCode.cdm.json/DataRequirementCodeFilterValueCode' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataReqCodeFilterValueCodeableConcept.cdm.json/DataReqCodeFilterValueCodeableConcept' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementCodeFilterValueCoding.cdm.json/DataRequirementCodeFilterValueCoding' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementDateFilter.cdm.json/DataRequirementDateFilter' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementMustSupport.cdm.json/DataRequirementMustSupport' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DataRequirementProfile.cdm.json/DataRequirementProfile' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponent.cdm.json/DeviceComponent' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponentOperationalStatus.cdm.json/DeviceComponentOperationalStatus' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/DeviceComponentProductionSpecification.cdm.json/DeviceComponentProductionSpecification' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Endpoint.cdm.json/Endpoint' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointContact.cdm.json/EndpointContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointHeader.cdm.json/EndpointHeader' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointPayloadMimeType.cdm.json/EndpointPayloadMimeType' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/EndpointPayloadType.cdm.json/EndpointPayloadType' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareService.cdm.json/HealthcareService' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceAvailableTime.cdm.json/HealthcareServiceAvailableTime' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCategory.cdm.json/HealthcareServiceCategory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCharacteristic.cdm.json/HealthcareServiceCharacteristic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceCoverageArea.cdm.json/HealthcareServiceCoverageArea' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceEndpoint.cdm.json/HealthcareServiceEndpoint' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceLocation.cdm.json/HealthcareServiceLocation' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceProgramName.cdm.json/HealthcareServiceProgramName' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceProvision.cdm.json/HealthcareServiceProvision' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceReferralMethod.cdm.json/HealthcareServiceReferralMethod' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceSpecialty.cdm.json/HealthcareServiceSpecialty' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/HealthcareServiceTelecom.cdm.json/HealthcareServiceTelecom' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/ActivityDefinition.cdm.json/ActivityDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Location.cdm.json/Location' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/LocationTelecom.cdm.json/LocationTelecom' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinition.cdm.json/PlanDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionAction.cdm.json/PlanDefinitionAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionAction.cdm.json/PlanDefinitionActionAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionArtifact.cdm.json/PlanDefinitionActionArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionCode.cdm.json/PlanDefinitionActionCode' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionCondition.cdm.json/PlanDefinitionActionCondition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionDynamicValue.cdm.json/PlanDefinitionActionDynamicValue' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionGoal.cdm.json/PlanDefinitionActionGoal' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionInput.cdm.json/PlanDefinitionActionInput' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionOutput.cdm.json/PlanDefinitionActionOutput' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionReason.cdm.json/PlanDefinitionActionReason' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionRelatedAction.cdm.json/PlanDefinitionActionRelatedAction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionActionTriggerDefinition.cdm.json/PlanDefinitionActionTriggerDefinition' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionArtifact.cdm.json/PlanDefinitionArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionContributor.cdm.json/PlanDefinitionContributor' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionContributorContact.cdm.json/PlanDefinitionContributorContact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoal.cdm.json/PlanDefinitionGoal' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalAddresses.cdm.json/PlanDefinitionGoalAddresses' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalArtifact.cdm.json/PlanDefinitionGoalArtifact' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionGoalTarget.cdm.json/PlanDefinitionGoalTarget' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionJurisdiction.cdm.json/PlanDefinitionJurisdiction' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionLibrary.cdm.json/PlanDefinitionLibrary' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionParticipant.cdm.json/PlanDefinitionParticipant' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionTopic.cdm.json/PlanDefinitionTopic' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/PlanDefinitionUseContext.cdm.json/PlanDefinitionUseContext' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Substance.cdm.json/Substance' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceCategory.cdm.json/SubstanceCategory' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceIngredient.cdm.json/SubstanceIngredient' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/SubstanceInstance.cdm.json/SubstanceInstance' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/Timing.cdm.json/Timing' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingDayOfWeek.cdm.json/TimingDayOfWeek' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingEvent.cdm.json/TimingEvent' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingTimeOfDay.cdm.json/TimingTimeOfDay' with Property 'OrganizationId'
            ///Property <see cref="OrganizationId"/> from Vocab 'foundationCommon/crmCommon/accelerators/healthCare/electronicMedicalRecords/TimingWhen.cdm.json/TimingWhen' with Property 'OrganizationId'
            #endregion
        }

        public VocabularyKey ACIWebEndpointUrl { get; private set; }
        public VocabularyKey AcknowledgementTemplateId { get; private set; }
        public VocabularyKey AllowAddressBookSyncs { get; private set; }
        public VocabularyKey AllowAutoResponseCreation { get; private set; }
        public VocabularyKey AllowAutoUnsubscribe { get; private set; }
        public VocabularyKey AllowAutoUnsubscribeAcknowledgement { get; private set; }
        public VocabularyKey AllowClientMessageBarAd { get; private set; }
        public VocabularyKey AllowEntityOnlyAudit { get; private set; }
        public VocabularyKey AllowLegacyDialogsEmbedding { get; private set; }
        public VocabularyKey AllowMarketingEmailExecution { get; private set; }
        public VocabularyKey AllowOfflineScheduledSyncs { get; private set; }
        public VocabularyKey AllowOutlookScheduledSyncs { get; private set; }
        public VocabularyKey AllowUnresolvedPartiesOnEmailSend { get; private set; }
        public VocabularyKey AllowUserFormModePreference { get; private set; }
        public VocabularyKey AllowUsersSeeAppdownloadMessage { get; private set; }
        public VocabularyKey AllowWebExcelExport { get; private set; }
        public VocabularyKey AMDesignator { get; private set; }
        public VocabularyKey AppDesignerExperienceEnabled { get; private set; }
        public VocabularyKey AppointmentRichEditorExperience { get; private set; }
        public VocabularyKey AutoApplyDefaultonCaseCreate { get; private set; }
        public VocabularyKey AutoApplyDefaultonCaseUpdate { get; private set; }
        public VocabularyKey AutoApplySLA { get; private set; }
        public VocabularyKey AzureSchedulerJobCollectionName { get; private set; }
        public VocabularyKey BaseCurrencyPrecision { get; private set; }
        public VocabularyKey BaseCurrencySymbol { get; private set; }
        public VocabularyKey BingMapsApiKey { get; private set; }
        public VocabularyKey BlockedAttachments { get; private set; }
        public VocabularyKey BoundDashboardDefaultCardExpanded { get; private set; }
        public VocabularyKey BulkOperationPrefix { get; private set; }
        public VocabularyKey BusinessClosureCalendarId { get; private set; }
        public VocabularyKey CalendarType { get; private set; }
        public VocabularyKey CampaignPrefix { get; private set; }
        public VocabularyKey CascadeStatusUpdate { get; private set; }
        public VocabularyKey CasePrefix { get; private set; }
        public VocabularyKey CategoryPrefix { get; private set; }
        public VocabularyKey ClientFeatureSet { get; private set; }
        public VocabularyKey ContractPrefix { get; private set; }
        public VocabularyKey CortanaProactiveExperienceEnabled { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreateProductsWithoutParentInActiveState { get; private set; }
        public VocabularyKey CurrencyDecimalPrecision { get; private set; }
        public VocabularyKey CurrencyDisplayOption { get; private set; }
        public VocabularyKey CurrencyFormatCode { get; private set; }
        public VocabularyKey CurrencySymbol { get; private set; }
        public VocabularyKey CurrentBulkOperationNumber { get; private set; }
        public VocabularyKey CurrentCampaignNumber { get; private set; }
        public VocabularyKey CurrentCaseNumber { get; private set; }
        public VocabularyKey CurrentCategoryNumber { get; private set; }
        public VocabularyKey CurrentContractNumber { get; private set; }
        public VocabularyKey CurrentImportSequenceNumber { get; private set; }
        public VocabularyKey CurrentInvoiceNumber { get; private set; }
        public VocabularyKey CurrentKaNumber { get; private set; }
        public VocabularyKey CurrentKbNumber { get; private set; }
        public VocabularyKey CurrentOrderNumber { get; private set; }
        public VocabularyKey CurrentParsedTableNumber { get; private set; }
        public VocabularyKey CurrentQuoteNumber { get; private set; }
        public VocabularyKey DateFormatCode { get; private set; }
        public VocabularyKey DateFormatString { get; private set; }
        public VocabularyKey DateSeparator { get; private set; }
        public VocabularyKey DaysSinceRecordLastModifiedMaxValue { get; private set; }
        public VocabularyKey DecimalSymbol { get; private set; }
        public VocabularyKey DefaultCountryCode { get; private set; }
        public VocabularyKey DefaultCrmCustomName { get; private set; }
        public VocabularyKey DefaultEmailServerProfileId { get; private set; }
        public VocabularyKey DefaultEmailSettings { get; private set; }
        public VocabularyKey DefaultMobileOfflineProfileId { get; private set; }
        public VocabularyKey DefaultRecurrenceEndRangeType { get; private set; }
        public VocabularyKey DefaultThemeData { get; private set; }
        public VocabularyKey DelegatedAdminUserId { get; private set; }
        public VocabularyKey DisabledReason { get; private set; }
        public VocabularyKey DisableSocialCare { get; private set; }
        public VocabularyKey DiscountCalculationMethod { get; private set; }
        public VocabularyKey DisplayNavigationTour { get; private set; }
        public VocabularyKey EmailConnectionChannel { get; private set; }
        public VocabularyKey EmailCorrelationEnabled { get; private set; }
        public VocabularyKey EmailSendPollingPeriod { get; private set; }
        public VocabularyKey EnableBingMapsIntegration { get; private set; }
        public VocabularyKey EnableImmersiveSkypeIntegration { get; private set; }
        public VocabularyKey EnableLPAuthoring { get; private set; }
        public VocabularyKey EnableMicrosoftFlowIntegration { get; private set; }
        public VocabularyKey EnablePricingOnCreate { get; private set; }
        public VocabularyKey EnableSmartMatching { get; private set; }
        public VocabularyKey EnforceReadOnlyPlugins { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExpireChangeTrackingInDays { get; private set; }
        public VocabularyKey ExpireSubscriptionsInDays { get; private set; }
        public VocabularyKey ExternalBaseUrl { get; private set; }
        public VocabularyKey ExternalPartyCorrelationKeys { get; private set; }
        public VocabularyKey ExternalPartyEntitySettings { get; private set; }
        public VocabularyKey FeatureSet { get; private set; }
        public VocabularyKey FiscalCalendarStart { get; private set; }
        public VocabularyKey FiscalPeriodFormat { get; private set; }
        public VocabularyKey FiscalPeriodFormatPeriod { get; private set; }
        public VocabularyKey FiscalPeriodType { get; private set; }
        public VocabularyKey FiscalSettingsUpdated { get; private set; }
        public VocabularyKey FiscalYearDisplayCode { get; private set; }
        public VocabularyKey FiscalYearFormat { get; private set; }
        public VocabularyKey FiscalYearFormatPrefix { get; private set; }
        public VocabularyKey FiscalYearFormatSuffix { get; private set; }
        public VocabularyKey FiscalYearFormatYear { get; private set; }
        public VocabularyKey FiscalYearPeriodConnect { get; private set; }
        public VocabularyKey FullNameConventionCode { get; private set; }
        public VocabularyKey FutureExpansionWindow { get; private set; }
        public VocabularyKey GenerateAlertsForErrors { get; private set; }
        public VocabularyKey GenerateAlertsForInformation { get; private set; }
        public VocabularyKey GenerateAlertsForWarnings { get; private set; }
        public VocabularyKey GetStartedPaneContentEnabled { get; private set; }
        public VocabularyKey GlobalAppendUrlParametersEnabled { get; private set; }
        public VocabularyKey GlobalHelpUrl { get; private set; }
        public VocabularyKey GlobalHelpUrlEnabled { get; private set; }
        public VocabularyKey GoalRollupExpiryTime { get; private set; }
        public VocabularyKey GoalRollupFrequency { get; private set; }
        public VocabularyKey GrantAccessToNetworkService { get; private set; }
        public VocabularyKey HashDeltaSubjectCount { get; private set; }
        public VocabularyKey HashFilterKeywords { get; private set; }
        public VocabularyKey HashMaxCount { get; private set; }
        public VocabularyKey HashMinAddressCount { get; private set; }
        public VocabularyKey HighContrastThemeData { get; private set; }
        public VocabularyKey IgnoreInternalEmail { get; private set; }
        public VocabularyKey InactivityTimeoutEnabled { get; private set; }
        public VocabularyKey InactivityTimeoutInMins { get; private set; }
        public VocabularyKey InactivityTimeoutReminderInMins { get; private set; }
        public VocabularyKey IncomingEmailExchangeEmailRetrievalBatchSize { get; private set; }
        public VocabularyKey InitialVersion { get; private set; }
        public VocabularyKey IntegrationUserId { get; private set; }
        public VocabularyKey InvoicePrefix { get; private set; }
        public VocabularyKey IsActionCardEnabled { get; private set; }
        public VocabularyKey IsActionSupportFeatureEnabled { get; private set; }
        public VocabularyKey IsActivityAnalysisEnabled { get; private set; }
        public VocabularyKey IsAppMode { get; private set; }
        public VocabularyKey IsAppointmentAttachmentSyncEnabled { get; private set; }
        public VocabularyKey IsAssignedTasksSyncEnabled { get; private set; }
        public VocabularyKey IsAuditEnabled { get; private set; }
        public VocabularyKey IsAutoDataCaptureEnabled { get; private set; }
        public VocabularyKey IsAutoSaveEnabled { get; private set; }
        public VocabularyKey IsBPFEntityCustomizationFeatureEnabled { get; private set; }
        public VocabularyKey IsConflictDetectionEnabledForMobileClient { get; private set; }
        public VocabularyKey IsContactMailingAddressSyncEnabled { get; private set; }
        public VocabularyKey IsDefaultCountryCodeCheckEnabled { get; private set; }
        public VocabularyKey IsDelegateAccessEnabled { get; private set; }
        public VocabularyKey IsDelveActionHubIntegrationEnabled { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey IsDuplicateDetectionEnabled { get; private set; }
        public VocabularyKey IsDuplicateDetectionEnabledForImport { get; private set; }
        public VocabularyKey IsDuplicateDetectionEnabledForOfflineSync { get; private set; }
        public VocabularyKey IsDuplicateDetectionEnabledForOnlineCreateUpdate { get; private set; }
        public VocabularyKey IsEmailMonitoringAllowed { get; private set; }
        public VocabularyKey IsEmailServerProfileContentFilteringEnabled { get; private set; }
        public VocabularyKey IsEnabledForAllRoles { get; private set; }
        public VocabularyKey IsExternalFileStorageEnabled { get; private set; }
        public VocabularyKey IsExternalSearchIndexEnabled { get; private set; }
        public VocabularyKey IsFiscalPeriodMonthBased { get; private set; }
        public VocabularyKey IsFolderAutoCreatedonSP { get; private set; }
        public VocabularyKey IsFolderBasedTrackingEnabled { get; private set; }
        public VocabularyKey IsFullTextSearchEnabled { get; private set; }
        public VocabularyKey IsHierarchicalSecurityModelEnabled { get; private set; }
        public VocabularyKey IsMailboxForcedUnlockingEnabled { get; private set; }
        public VocabularyKey IsMailboxInactiveBackoffEnabled { get; private set; }
        public VocabularyKey IsMobileClientOnDemandSyncEnabled { get; private set; }
        public VocabularyKey IsMobileOfflineEnabled { get; private set; }
        public VocabularyKey IsNotesAnalysisEnabled { get; private set; }
        public VocabularyKey IsOfficeGraphEnabled { get; private set; }
        public VocabularyKey IsOneDriveEnabled { get; private set; }
        public VocabularyKey IsPresenceEnabled { get; private set; }
        public VocabularyKey IsPreviewEnabledForActionCard { get; private set; }
        public VocabularyKey IsPreviewForAutoCaptureEnabled { get; private set; }
        public VocabularyKey IsPreviewForEmailMonitoringAllowed { get; private set; }
        public VocabularyKey IsReadAuditEnabled { get; private set; }
        public VocabularyKey IsRegistered { get; private set; }
        public VocabularyKey IsRelationshipInsightsEnabled { get; private set; }
        public VocabularyKey IsResourceBookingExchangeSyncEnabled { get; private set; }
        public VocabularyKey IsSOPIntegrationEnabled { get; private set; }
        public VocabularyKey IsTextWrapEnabled { get; private set; }
        public VocabularyKey IsUserAccessAuditEnabled { get; private set; }
        public VocabularyKey ISVIntegrationCode { get; private set; }
        public VocabularyKey KaPrefix { get; private set; }
        public VocabularyKey KbPrefix { get; private set; }
        public VocabularyKey KMSettings { get; private set; }
        public VocabularyKey LanguageCode { get; private set; }
        public VocabularyKey LocaleId { get; private set; }
        public VocabularyKey LongDateFormatCode { get; private set; }
        public VocabularyKey MailboxIntermittentIssueMinRange { get; private set; }
        public VocabularyKey MailboxPermanentIssueMinRange { get; private set; }
        public VocabularyKey MaxActionStepsInBPF { get; private set; }
        public VocabularyKey MaxAppointmentDurationDays { get; private set; }
        public VocabularyKey MaxConditionsForMobileOfflineFilters { get; private set; }
        public VocabularyKey MaxDepthForHierarchicalSecurityModel { get; private set; }
        public VocabularyKey MaxFolderBasedTrackingMappings { get; private set; }
        public VocabularyKey MaximumActiveBusinessProcessFlowsAllowedPerEntity { get; private set; }
        public VocabularyKey MaximumDynamicPropertiesAllowed { get; private set; }
        public VocabularyKey MaximumEntitiesWithActiveSLA { get; private set; }
        public VocabularyKey MaximumSLAKPIPerEntityWithActiveSLA { get; private set; }
        public VocabularyKey MaximumTrackingNumber { get; private set; }
        public VocabularyKey MaxProductsInBundle { get; private set; }
        public VocabularyKey MaxRecordsForExportToExcel { get; private set; }
        public VocabularyKey MaxRecordsForLookupFilters { get; private set; }
        public VocabularyKey MaxSupportedInternetExplorerVersion { get; private set; }
        public VocabularyKey MaxUploadFileSize { get; private set; }
        public VocabularyKey MaxVerboseLoggingMailbox { get; private set; }
        public VocabularyKey MaxVerboseLoggingSyncCycles { get; private set; }
        public VocabularyKey MicrosoftFlowEnvironment { get; private set; }
        public VocabularyKey MinAddressBookSyncInterval { get; private set; }
        public VocabularyKey MinOfflineSyncInterval { get; private set; }
        public VocabularyKey MinOutlookSyncInterval { get; private set; }
        public VocabularyKey MobileOfflineMinLicenseProd { get; private set; }
        public VocabularyKey MobileOfflineMinLicenseTrial { get; private set; }
        public VocabularyKey MobileOfflineSyncInterval { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NegativeCurrencyFormatCode { get; private set; }
        public VocabularyKey NegativeFormatCode { get; private set; }
        public VocabularyKey NextTrackingNumber { get; private set; }
        public VocabularyKey NotifyMailboxOwnerOfEmailServerLevelAlerts { get; private set; }
        public VocabularyKey NumberFormat { get; private set; }
        public VocabularyKey NumberGroupFormat { get; private set; }
        public VocabularyKey NumberSeparator { get; private set; }
        public VocabularyKey OfficeAppsAutoDeploymentEnabled { get; private set; }
        public VocabularyKey OfficeGraphDelveUrl { get; private set; }
        public VocabularyKey OOBPriceCalculationEnabled { get; private set; }
        public VocabularyKey OrderPrefix { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey OrganizationState { get; private set; }
        public VocabularyKey OrgDbOrgSettings { get; private set; }
        public VocabularyKey OrgInsightsEnabled { get; private set; }
        public VocabularyKey ParsedTableColumnPrefix { get; private set; }
        public VocabularyKey ParsedTablePrefix { get; private set; }
        public VocabularyKey PastExpansionWindow { get; private set; }
        public VocabularyKey Picture { get; private set; }
        public VocabularyKey PinpointLanguageCode { get; private set; }
        public VocabularyKey PluginTraceLogSetting { get; private set; }
        public VocabularyKey PMDesignator { get; private set; }
        public VocabularyKey PostMessageWhitelistDomains { get; private set; }
        public VocabularyKey PowerBiFeatureEnabled { get; private set; }
        public VocabularyKey PricingDecimalPrecision { get; private set; }
        public VocabularyKey PrivacyStatementUrl { get; private set; }
        public VocabularyKey PrivilegeUserGroupId { get; private set; }
        public VocabularyKey PrivReportingGroupId { get; private set; }
        public VocabularyKey PrivReportingGroupName { get; private set; }
        public VocabularyKey ProductRecommendationsEnabled { get; private set; }
        public VocabularyKey QuickFindRecordLimitEnabled { get; private set; }
        public VocabularyKey QuotePrefix { get; private set; }
        public VocabularyKey RecurrenceDefaultNumberOfOccurrences { get; private set; }
        public VocabularyKey RecurrenceExpansionJobBatchInterval { get; private set; }
        public VocabularyKey RecurrenceExpansionJobBatchSize { get; private set; }
        public VocabularyKey RecurrenceExpansionSynchCreateMax { get; private set; }
        public VocabularyKey ReferenceSiteMapXml { get; private set; }
        public VocabularyKey RenderSecureIFrameForEmail { get; private set; }
        public VocabularyKey ReportingGroupId { get; private set; }
        public VocabularyKey ReportingGroupName { get; private set; }
        public VocabularyKey ReportScriptErrors { get; private set; }
        public VocabularyKey RequireApprovalForQueueEmail { get; private set; }
        public VocabularyKey RequireApprovalForUserEmail { get; private set; }
        public VocabularyKey ResolveSimilarUnresolvedEmailAddress { get; private set; }
        public VocabularyKey RestrictStatusUpdate { get; private set; }
        public VocabularyKey RiErrorStatus { get; private set; }
        public VocabularyKey SampleDataImportId { get; private set; }
        public VocabularyKey SchedulingEngine { get; private set; }
        public VocabularyKey SchemaNamePrefix { get; private set; }
        public VocabularyKey ServeStaticResourcesFromAzureCDN { get; private set; }
        public VocabularyKey SessionTimeoutEnabled { get; private set; }
        public VocabularyKey SessionTimeoutInMins { get; private set; }
        public VocabularyKey SessionTimeoutReminderInMins { get; private set; }
        public VocabularyKey SharePointDeploymentType { get; private set; }
        public VocabularyKey ShareToPreviousOwnerOnAssign { get; private set; }
        public VocabularyKey ShowKBArticleDeprecationNotification { get; private set; }
        public VocabularyKey ShowWeekNumber { get; private set; }
        public VocabularyKey SignupOutlookDownloadFWLink { get; private set; }
        public VocabularyKey SiteMapXml { get; private set; }
        public VocabularyKey SlaPauseStates { get; private set; }
        public VocabularyKey SocialInsightsEnabled { get; private set; }
        public VocabularyKey SocialInsightsInstance { get; private set; }
        public VocabularyKey SocialInsightsTermsAccepted { get; private set; }
        public VocabularyKey SortId { get; private set; }
        public VocabularyKey SqlAccessGroupId { get; private set; }
        public VocabularyKey SqlAccessGroupName { get; private set; }
        public VocabularyKey SQMEnabled { get; private set; }
        public VocabularyKey SupportUserId { get; private set; }
        public VocabularyKey SuppressSLA { get; private set; }
        public VocabularyKey SyncOptInSelection { get; private set; }
        public VocabularyKey SyncOptInSelectionStatus { get; private set; }
        public VocabularyKey SystemUserId { get; private set; }
        public VocabularyKey TagMaxAggressiveCycles { get; private set; }
        public VocabularyKey TagPollingPeriod { get; private set; }
        public VocabularyKey TaskBasedFlowEnabled { get; private set; }
        public VocabularyKey TextAnalyticsEnabled { get; private set; }
        public VocabularyKey TimeFormatCode { get; private set; }
        public VocabularyKey TimeFormatString { get; private set; }
        public VocabularyKey TimeSeparator { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey TokenExpiry { get; private set; }
        public VocabularyKey TrackingPrefix { get; private set; }
        public VocabularyKey TrackingTokenIdBase { get; private set; }
        public VocabularyKey TrackingTokenIdDigits { get; private set; }
        public VocabularyKey UniqueSpecifierLength { get; private set; }
        public VocabularyKey UnresolveEmailAddressIfMultipleMatch { get; private set; }
        public VocabularyKey UseInbuiltRuleForDefaultPricelistSelection { get; private set; }
        public VocabularyKey UseLegacyRendering { get; private set; }
        public VocabularyKey UsePositionHierarchy { get; private set; }
        public VocabularyKey UserAccessAuditingInterval { get; private set; }
        public VocabularyKey UseReadForm { get; private set; }
        public VocabularyKey UserGroupId { get; private set; }
        public VocabularyKey UseSkypeProtocol { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey V3CalloutConfigHash { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey WebResourceHash { get; private set; }
        public VocabularyKey WeekStartDayCode { get; private set; }
        public VocabularyKey WidgetProperties { get; private set; }
        public VocabularyKey YammerGroupId { get; private set; }
        public VocabularyKey YammerNetworkPermalink { get; private set; }
        public VocabularyKey YammerOAuthAccessTokenExpired { get; private set; }
        public VocabularyKey YammerPostMethod { get; private set; }
        public VocabularyKey YearStartWeekCode { get; private set; }
    }
}