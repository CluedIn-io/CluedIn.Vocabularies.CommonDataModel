using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentCalendarEntityVocabulary : SimpleVocabulary
    {
        public PaymentCalendarEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentCalendarEntity";
            KeyPrefix = "commonDataModel.paymentcalendarentity";
            KeySeparator = ".";
            Grouping = "/PaymentCalendarEntity";

            AddGroup("Common Data Model PaymentCalendarEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsMondayBusinessDay = group.Add(new VocabularyKey(nameof(IsMondayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTuesdayBusinessDay = group.Add(new VocabularyKey(nameof(IsTuesdayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWednesdayBusinessDay = group.Add(new VocabularyKey(nameof(IsWednesdayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsThursdayBusinessDay = group.Add(new VocabularyKey(nameof(IsThursdayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsFridayBusinessDay = group.Add(new VocabularyKey(nameof(IsFridayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSaturdayBusinessDay = group.Add(new VocabularyKey(nameof(IsSaturdayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSundayBusinessDay = group.Add(new VocabularyKey(nameof(IsSundayBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey IsMondayBusinessDay { get; private set; }
public VocabularyKey IsTuesdayBusinessDay { get; private set; }
public VocabularyKey IsWednesdayBusinessDay { get; private set; }
public VocabularyKey IsThursdayBusinessDay { get; private set; }
public VocabularyKey IsFridayBusinessDay { get; private set; }
public VocabularyKey IsSaturdayBusinessDay { get; private set; }
public VocabularyKey IsSundayBusinessDay { get; private set; }
public VocabularyKey CountryRegion { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }


    }
}