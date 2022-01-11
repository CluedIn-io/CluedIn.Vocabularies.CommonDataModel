using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionJournalNameEntityVocabulary : SimpleVocabulary
    {
        public ProductionJournalNameEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionJournalNameEntity";
            KeyPrefix = "commonDataModel.productionjournalnameentity";
            KeySeparator = ".";
            Grouping = "/ProductionJournalNameEntity";

            AddGroup("Common Data Model ProductionJournalNameEntity Details", group =>
            {
                VoucherSeqRecId = group.Add(new VocabularyKey(nameof(VoucherSeqRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalNameId = group.Add(new VocabularyKey(nameof(JournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPrivateUserGroupId = group.Add(new VocabularyKey(nameof(DefaultPrivateUserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillPostingDeleteLinesByDefault = group.Add(new VocabularyKey(nameof(WillPostingDeleteLinesByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultJournalDescription = group.Add(new VocabularyKey(nameof(DefaultJournalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPostingSummationLevel = group.Add(new VocabularyKey(nameof(DefaultPostingSummationLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoucherNumberAllocationRule = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberAllocationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoucherNumberSelectionRule = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSelectionRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoucherNumberSequenceCode = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoucherNumberSequenceRecId = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultVoucherNumberSequenceDataArea = group.Add(new VocabularyKey(nameof(DefaultVoucherNumberSequenceDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VoucherSeqRecId { get; private set; }
public VocabularyKey JournalNameId { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey DefaultPrivateUserGroupId { get; private set; }
public VocabularyKey WillPostingDeleteLinesByDefault { get; private set; }
public VocabularyKey DefaultJournalDescription { get; private set; }
public VocabularyKey DefaultPostingSummationLevel { get; private set; }
public VocabularyKey DefaultVoucherNumberAllocationRule { get; private set; }
public VocabularyKey DefaultVoucherNumberSelectionRule { get; private set; }
public VocabularyKey DefaultVoucherNumberSequenceCode { get; private set; }
public VocabularyKey DefaultVoucherNumberSequenceRecId { get; private set; }
public VocabularyKey DefaultVoucherNumberSequenceDataArea { get; private set; }


    }
}