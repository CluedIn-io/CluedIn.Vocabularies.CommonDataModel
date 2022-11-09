using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class StateHolidayEntityVocabulary : SimpleVocabulary
    {
        public StateHolidayEntityVocabulary()
        {
            VocabularyName = "Common Data Model StateHolidayEntity";
            KeyPrefix = "commonDataModel.stateholidayentity";
            KeySeparator = ".";
            Grouping = "/StateHolidayEntity";

            AddGroup("Common Data Model StateHolidayEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HolidayDate = group.Add(new VocabularyKey(nameof(HolidayDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey HolidayDate { get; private set; }
public VocabularyKey State { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey StateId { get; private set; }


    }
}