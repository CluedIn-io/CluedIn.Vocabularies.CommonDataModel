using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderEntryDeadlineEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderEntryDeadlineEntityVocabulary()
        {
            VocabularyName = "SalesOrderEntryDeadlineEntity";
            KeyPrefix = "commonDataModel.salesorderentrydeadlineentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderEntryDeadlineEntity";

            AddGroup("SalesOrderEntryDeadlineEntity Details", group =>
            {
                DeadlineGroupCode = group.Add(new VocabularyKey(nameof(DeadlineGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderEntryDeadlineGroupId = group.Add(new VocabularyKey(nameof(SalesOrderEntryDeadlineGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteCode = group.Add(new VocabularyKey(nameof(SiteCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeMonday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeTuesday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeWednesday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeThursday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeFriday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeSaturday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LatestOrderEntryTimeSunday = group.Add(new VocabularyKey(nameof(LatestOrderEntryTimeSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DeadlineGroupCode { get; private set; }
        public VocabularyKey SalesOrderEntryDeadlineGroupId { get; private set; }
        public VocabularyKey SiteCode { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey LatestOrderEntryTimeMonday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeTuesday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeWednesday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeThursday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeFriday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeSaturday { get; private set; }
        public VocabularyKey LatestOrderEntryTimeSunday { get; private set; }


    }
}