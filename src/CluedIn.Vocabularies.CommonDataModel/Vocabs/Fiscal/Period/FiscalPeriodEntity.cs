using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalPeriodEntityVocabulary : SimpleVocabulary
    {
        public FiscalPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalPeriodEntity";
            KeyPrefix = "commonDataModel.fiscalperiodentity";
            KeySeparator = ".";
            Grouping = "/FiscalPeriodEntity";

            AddGroup("Common Data Model FiscalPeriodEntity Details", group =>
            {
                Comments = group.Add(new VocabularyKey(nameof(Comments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Month = group.Add(new VocabularyKey(nameof(Month), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodName = group.Add(new VocabularyKey(nameof(PeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quarter = group.Add(new VocabularyKey(nameof(Quarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShortName = group.Add(new VocabularyKey(nameof(ShortName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CalendarType = group.Add(new VocabularyKey(nameof(CalendarType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Days = group.Add(new VocabularyKey(nameof(Days), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Comments { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey Month { get; private set; }
public VocabularyKey PeriodName { get; private set; }
public VocabularyKey Quarter { get; private set; }
public VocabularyKey ShortName { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey Type { get; private set; }
public VocabularyKey Calendar { get; private set; }
public VocabularyKey FiscalYear { get; private set; }
public VocabularyKey CalendarType { get; private set; }
public VocabularyKey Days { get; private set; }


    }
}