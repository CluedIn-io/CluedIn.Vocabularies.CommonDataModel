using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalYearEntityVocabulary : SimpleVocabulary
    {
        public FiscalYearEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalYearEntity";
            KeyPrefix = "commonDataModel.fiscalyearentity";
            KeySeparator = ".";
            Grouping = "/FiscalYearEntity";

            AddGroup("Common Data Model FiscalYearEntity Details", group =>
            {
                Calendar = group.Add(new VocabularyKey(nameof(Calendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Calendar { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey FiscalYear { get; private set; }


    }
}