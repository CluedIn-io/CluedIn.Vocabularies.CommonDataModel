using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountValidationPeriodEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountValidationPeriodEntityVocabulary()
        {
            VocabularyName = "Retail Discount Validation Period Entity";
            KeyPrefix = "commonDataModel.retaildiscountvalidationperiodentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountValidationPeriodEntity";

            AddGroup("RetailDiscountValidationPeriodEntity Details", group =>
            {
                EndingTime = group.Add(new VocabularyKey(nameof(EndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(EndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FridayEndingTime = group.Add(new VocabularyKey(nameof(FridayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FridayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(FridayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FridayStartingTime = group.Add(new VocabularyKey(nameof(FridayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FridayTimeWithinBounds = group.Add(new VocabularyKey(nameof(FridayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MondayEndingTime = group.Add(new VocabularyKey(nameof(MondayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MondayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(MondayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MondayStartingTime = group.Add(new VocabularyKey(nameof(MondayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MondayTimeWithinBounds = group.Add(new VocabularyKey(nameof(MondayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaturdayEndingTime = group.Add(new VocabularyKey(nameof(SaturdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaturdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(SaturdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaturdayStartingTime = group.Add(new VocabularyKey(nameof(SaturdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaturdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(SaturdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartingTime = group.Add(new VocabularyKey(nameof(StartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SundayEndingTime = group.Add(new VocabularyKey(nameof(SundayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SundayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(SundayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SundayStartingTime = group.Add(new VocabularyKey(nameof(SundayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SundayTimeWithinBounds = group.Add(new VocabularyKey(nameof(SundayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TuesdayEndingTime = group.Add(new VocabularyKey(nameof(TuesdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TuesdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(TuesdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TuesdayStartingTime = group.Add(new VocabularyKey(nameof(TuesdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TuesdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(TuesdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThursdayEndingTime = group.Add(new VocabularyKey(nameof(ThursdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThursdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(ThursdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThursdayStartingTime = group.Add(new VocabularyKey(nameof(ThursdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThursdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(ThursdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeWithinBounds = group.Add(new VocabularyKey(nameof(TimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WednesdayEndingTime = group.Add(new VocabularyKey(nameof(WednesdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WednesdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(WednesdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WednesdayStartingTime = group.Add(new VocabularyKey(nameof(WednesdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WednesdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(WednesdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EndingTime { get; private set; }
        public VocabularyKey EndingTimeAfterMidnight { get; private set; }
        public VocabularyKey FridayEndingTime { get; private set; }
        public VocabularyKey FridayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey FridayStartingTime { get; private set; }
        public VocabularyKey FridayTimeWithinBounds { get; private set; }
        public VocabularyKey MondayEndingTime { get; private set; }
        public VocabularyKey MondayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey MondayStartingTime { get; private set; }
        public VocabularyKey MondayTimeWithinBounds { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey SaturdayEndingTime { get; private set; }
        public VocabularyKey SaturdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey SaturdayStartingTime { get; private set; }
        public VocabularyKey SaturdayTimeWithinBounds { get; private set; }
        public VocabularyKey StartingTime { get; private set; }
        public VocabularyKey SundayEndingTime { get; private set; }
        public VocabularyKey SundayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey SundayStartingTime { get; private set; }
        public VocabularyKey SundayTimeWithinBounds { get; private set; }
        public VocabularyKey TuesdayEndingTime { get; private set; }
        public VocabularyKey TuesdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey TuesdayStartingTime { get; private set; }
        public VocabularyKey TuesdayTimeWithinBounds { get; private set; }
        public VocabularyKey ThursdayEndingTime { get; private set; }
        public VocabularyKey ThursdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey ThursdayStartingTime { get; private set; }
        public VocabularyKey ThursdayTimeWithinBounds { get; private set; }
        public VocabularyKey TimeWithinBounds { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey WednesdayEndingTime { get; private set; }
        public VocabularyKey WednesdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey WednesdayStartingTime { get; private set; }
        public VocabularyKey WednesdayTimeWithinBounds { get; private set; }
    }
}