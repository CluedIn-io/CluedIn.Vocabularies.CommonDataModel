using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMPaymentDeductionTypeEntityVocabulary : SimpleVocabulary
    {
        public TAMPaymentDeductionTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TAMPaymentDeductionTypeEntity";
            KeyPrefix = "commonDataModel.tampaymentdeductiontypeentity";
            KeySeparator = ".";
            Grouping = "/TAMPaymentDeductionTypeEntity";

            AddGroup("Common Data Model TAMPaymentDeductionTypeEntity Details", group =>
            {
                DeductionOffsetLedgerAccount = group.Add(new VocabularyKey(nameof(DeductionOffsetLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeDescription = group.Add(new VocabularyKey(nameof(TypeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeductionOffsetLedgerAccountDisplayValue = group.Add(new VocabularyKey(nameof(DeductionOffsetLedgerAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DeductionOffsetLedgerAccount { get; private set; }
public VocabularyKey TypeDescription { get; private set; }
public VocabularyKey TypeName { get; private set; }
public VocabularyKey DeductionOffsetLedgerAccountDisplayValue { get; private set; }


    }
}