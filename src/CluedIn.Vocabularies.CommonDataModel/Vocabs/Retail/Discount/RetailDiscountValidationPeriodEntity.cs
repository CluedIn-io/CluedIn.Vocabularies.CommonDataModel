using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountValidationPeriodEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountValidationPeriodEntityVocabulary()
        {
            VocabularyName = "RetailDiscountValidationPeriodEntity";
            KeyPrefix = "commonDataModel.retaildiscountvalidationperiodentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountValidationPeriodEntity";

            AddGroup("RetailDiscountValidationPeriodEntity Details", group =>
            {
                endingTime = group.Add(new VocabularyKey(nameof(endingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(endingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fridayEndingTime = group.Add(new VocabularyKey(nameof(fridayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fridayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(fridayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fridayStartingTime = group.Add(new VocabularyKey(nameof(fridayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fridayTimeWithinBounds = group.Add(new VocabularyKey(nameof(fridayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mondayEndingTime = group.Add(new VocabularyKey(nameof(mondayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mondayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(mondayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mondayStartingTime = group.Add(new VocabularyKey(nameof(mondayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                mondayTimeWithinBounds = group.Add(new VocabularyKey(nameof(mondayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                saturdayEndingTime = group.Add(new VocabularyKey(nameof(saturdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                saturdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(saturdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                saturdayStartingTime = group.Add(new VocabularyKey(nameof(saturdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                saturdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(saturdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                startingTime = group.Add(new VocabularyKey(nameof(startingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sundayEndingTime = group.Add(new VocabularyKey(nameof(sundayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sundayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(sundayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sundayStartingTime = group.Add(new VocabularyKey(nameof(sundayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                sundayTimeWithinBounds = group.Add(new VocabularyKey(nameof(sundayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tuesdayEndingTime = group.Add(new VocabularyKey(nameof(tuesdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tuesdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(tuesdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tuesdayStartingTime = group.Add(new VocabularyKey(nameof(tuesdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                tuesdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(tuesdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thursdayEndingTime = group.Add(new VocabularyKey(nameof(thursdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thursdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(thursdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thursdayStartingTime = group.Add(new VocabularyKey(nameof(thursdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                thursdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(thursdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeWithinBounds = group.Add(new VocabularyKey(nameof(timeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validFrom = group.Add(new VocabularyKey(nameof(validFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validTo = group.Add(new VocabularyKey(nameof(validTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                wednesdayEndingTime = group.Add(new VocabularyKey(nameof(wednesdayEndingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                wednesdayEndingTimeAfterMidnight = group.Add(new VocabularyKey(nameof(wednesdayEndingTimeAfterMidnight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                wednesdayStartingTime = group.Add(new VocabularyKey(nameof(wednesdayStartingTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                wednesdayTimeWithinBounds = group.Add(new VocabularyKey(nameof(wednesdayTimeWithinBounds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey endingTime { get; private set; }
        public VocabularyKey endingTimeAfterMidnight { get; private set; }
        public VocabularyKey fridayEndingTime { get; private set; }
        public VocabularyKey fridayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey fridayStartingTime { get; private set; }
        public VocabularyKey fridayTimeWithinBounds { get; private set; }
        public VocabularyKey mondayEndingTime { get; private set; }
        public VocabularyKey mondayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey mondayStartingTime { get; private set; }
        public VocabularyKey mondayTimeWithinBounds { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey PeriodId { get; private set; }
        public VocabularyKey saturdayEndingTime { get; private set; }
        public VocabularyKey saturdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey saturdayStartingTime { get; private set; }
        public VocabularyKey saturdayTimeWithinBounds { get; private set; }
        public VocabularyKey startingTime { get; private set; }
        public VocabularyKey sundayEndingTime { get; private set; }
        public VocabularyKey sundayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey sundayStartingTime { get; private set; }
        public VocabularyKey sundayTimeWithinBounds { get; private set; }
        public VocabularyKey tuesdayEndingTime { get; private set; }
        public VocabularyKey tuesdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey tuesdayStartingTime { get; private set; }
        public VocabularyKey tuesdayTimeWithinBounds { get; private set; }
        public VocabularyKey thursdayEndingTime { get; private set; }
        public VocabularyKey thursdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey thursdayStartingTime { get; private set; }
        public VocabularyKey thursdayTimeWithinBounds { get; private set; }
        public VocabularyKey timeWithinBounds { get; private set; }
        public VocabularyKey validFrom { get; private set; }
        public VocabularyKey validTo { get; private set; }
        public VocabularyKey wednesdayEndingTime { get; private set; }
        public VocabularyKey wednesdayEndingTimeAfterMidnight { get; private set; }
        public VocabularyKey wednesdayStartingTime { get; private set; }
        public VocabularyKey wednesdayTimeWithinBounds { get; private set; }


    }
}