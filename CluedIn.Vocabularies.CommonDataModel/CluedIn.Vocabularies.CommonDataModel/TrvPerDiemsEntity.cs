using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPerDiemsEntityVocabulary : SimpleVocabulary
    {
        public TrvPerDiemsEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvPerDiemsEntity";
            KeyPrefix = "commonDataModel.trvperdiemsentity";
            KeySeparator = ".";
            Grouping = "/TrvPerDiemsEntity";

            AddGroup("Common Data Model TrvPerDiemsEntity Details", group =>
            {
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateFrom = group.Add(new VocabularyKey(nameof(DateFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DateTo = group.Add(new VocabularyKey(nameof(DateTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HotelAllowance = group.Add(new VocabularyKey(nameof(HotelAllowance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MealAllowance = group.Add(new VocabularyKey(nameof(MealAllowance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OtherAllowance = group.Add(new VocabularyKey(nameof(OtherAllowance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductBreakf = group.Add(new VocabularyKey(nameof(DeductBreakf), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductDinner = group.Add(new VocabularyKey(nameof(DeductDinner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductLunch = group.Add(new VocabularyKey(nameof(DeductLunch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductOneMeal = group.Add(new VocabularyKey(nameof(DeductOneMeal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductThreeOrMoreMeals = group.Add(new VocabularyKey(nameof(DeductThreeOrMoreMeals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductTwoMeals = group.Add(new VocabularyKey(nameof(DeductTwoMeals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Currency { get; private set; }
public VocabularyKey DateFrom { get; private set; }
public VocabularyKey DateTo { get; private set; }
public VocabularyKey HotelAllowance { get; private set; }
public VocabularyKey Location { get; private set; }
public VocabularyKey StateId { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey MealAllowance { get; private set; }
public VocabularyKey OtherAllowance { get; private set; }
public VocabularyKey DeductBreakf { get; private set; }
public VocabularyKey DeductDinner { get; private set; }
public VocabularyKey DeductLunch { get; private set; }
public VocabularyKey DeductOneMeal { get; private set; }
public VocabularyKey DeductThreeOrMoreMeals { get; private set; }
public VocabularyKey DeductTwoMeals { get; private set; }


    }
}