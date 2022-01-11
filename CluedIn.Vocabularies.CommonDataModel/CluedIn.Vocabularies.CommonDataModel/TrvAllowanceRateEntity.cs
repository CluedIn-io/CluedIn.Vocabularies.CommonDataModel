using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvAllowanceRateEntityVocabulary : SimpleVocabulary
    {
        public TrvAllowanceRateEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvAllowanceRateEntity";
            KeyPrefix = "commonDataModel.trvallowancerateentity";
            KeySeparator = ".";
            Grouping = "/TrvAllowanceRateEntity";

            AddGroup("Common Data Model TrvAllowanceRateEntity Details", group =>
            {
                ReductionInPercentageForBreakfast = group.Add(new VocabularyKey(nameof(ReductionInPercentageForBreakfast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReductionInPercentageForDinner = group.Add(new VocabularyKey(nameof(ReductionInPercentageForDinner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReductionInPercentageForLunch = group.Add(new VocabularyKey(nameof(ReductionInPercentageForLunch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PercentageReductionFor1Meal = group.Add(new VocabularyKey(nameof(PercentageReductionFor1Meal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PercentageReductionFor3OrMoreMeals = group.Add(new VocabularyKey(nameof(PercentageReductionFor3OrMoreMeals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PercentageReductionFor2Meals = group.Add(new VocabularyKey(nameof(PercentageReductionFor2Meals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumHours = group.Add(new VocabularyKey(nameof(MinimumHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HotelPercent = group.Add(new VocabularyKey(nameof(HotelPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MealPercent = group.Add(new VocabularyKey(nameof(MealPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OtherPercent = group.Add(new VocabularyKey(nameof(OtherPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumHours = group.Add(new VocabularyKey(nameof(MaximumHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ApplyTo = group.Add(new VocabularyKey(nameof(ApplyTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateFrom = group.Add(new VocabularyKey(nameof(DateFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateTo = group.Add(new VocabularyKey(nameof(DateTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ReductionInPercentageForBreakfast { get; private set; }
public VocabularyKey ReductionInPercentageForDinner { get; private set; }
public VocabularyKey ReductionInPercentageForLunch { get; private set; }
public VocabularyKey PercentageReductionFor1Meal { get; private set; }
public VocabularyKey PercentageReductionFor3OrMoreMeals { get; private set; }
public VocabularyKey PercentageReductionFor2Meals { get; private set; }
public VocabularyKey MinimumHours { get; private set; }
public VocabularyKey HotelPercent { get; private set; }
public VocabularyKey MealPercent { get; private set; }
public VocabularyKey OtherPercent { get; private set; }
public VocabularyKey Reference { get; private set; }
public VocabularyKey MaximumHours { get; private set; }
public VocabularyKey ApplyTo { get; private set; }
public VocabularyKey DateFrom { get; private set; }
public VocabularyKey DateTo { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey StateId { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }


    }
}