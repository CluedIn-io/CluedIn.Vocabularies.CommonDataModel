using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjJournalNameEntityVocabulary : SimpleVocabulary
    {
        public ProjJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjJournalNameEntity";
            KeyPrefix = "commonDataModel.projjournalnameentity";
            KeySeparator = ".";
            Grouping = "/ProjJournalNameEntity";

            AddGroup("Common Data Model ProjJournalNameEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DetailSummary = group.Add(new VocabularyKey(nameof(DetailSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Approve = group.Add(new VocabularyKey(nameof(Approve), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ShowStartOrEndTimes = group.Add(new VocabularyKey(nameof(ShowStartOrEndTimes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NewVoucherBy = group.Add(new VocabularyKey(nameof(NewVoucherBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SetVoucherDateTo = group.Add(new VocabularyKey(nameof(SetVoucherDateTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SelectionBy = group.Add(new VocabularyKey(nameof(SelectionBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VoucherSeries = group.Add(new VocabularyKey(nameof(VoucherSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceCode = group.Add(new VocabularyKey(nameof(NumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceScope = group.Add(new VocabularyKey(nameof(NumberSequenceScope), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceDataArea = group.Add(new VocabularyKey(nameof(NumberSequenceDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey DetailSummary { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey Approve { get; private set; }
public VocabularyKey ShowStartOrEndTimes { get; private set; }
public VocabularyKey NewVoucherBy { get; private set; }
public VocabularyKey SetVoucherDateTo { get; private set; }
public VocabularyKey SelectionBy { get; private set; }
public VocabularyKey VoucherSeries { get; private set; }
public VocabularyKey NumberSequenceCode { get; private set; }
public VocabularyKey NumberSequenceScope { get; private set; }
public VocabularyKey NumberSequenceDataArea { get; private set; }


    }
}