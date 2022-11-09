using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsGroupEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RDeferralsGroupEntity";
            KeyPrefix = "commonDataModel.rdeferralsgroupentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsGroupEntity";

            AddGroup("Common Data Model RDeferralsGroupEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModelNumber = group.Add(new VocabularyKey(nameof(ModelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeferralsGroup = group.Add(new VocabularyKey(nameof(DeferralsGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisposalDate = group.Add(new VocabularyKey(nameof(DisposalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BeginningDateOfWritingOff = group.Add(new VocabularyKey(nameof(BeginningDateOfWritingOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WritingOffTime = group.Add(new VocabularyKey(nameof(WritingOffTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WritingOffMethod = group.Add(new VocabularyKey(nameof(WritingOffMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VATOffsetMethodForDeferrals = group.Add(new VocabularyKey(nameof(VATOffsetMethodForDeferrals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Dimension { get; private set; }
public VocabularyKey ModelNumber { get; private set; }
public VocabularyKey DeferralsGroup { get; private set; }
public VocabularyKey DisposalDate { get; private set; }
public VocabularyKey BeginningDateOfWritingOff { get; private set; }
public VocabularyKey WritingOffTime { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey PostingProfile { get; private set; }
public VocabularyKey WritingOffMethod { get; private set; }
public VocabularyKey VATOffsetMethodForDeferrals { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }


    }
}