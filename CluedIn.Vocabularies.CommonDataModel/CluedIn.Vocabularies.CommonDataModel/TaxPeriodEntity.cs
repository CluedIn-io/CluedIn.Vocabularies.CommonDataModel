using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPeriodEntityVocabulary : SimpleVocabulary
    {
        public TaxPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxPeriodEntity";
            KeyPrefix = "commonDataModel.taxperiodentity";
            KeySeparator = ".";
            Grouping = "/TaxPeriodEntity";

            AddGroup("Common Data Model TaxPeriodEntity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPeriodId = group.Add(new VocabularyKey(nameof(TaxPeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxPaymentVersion = group.Add(new VocabularyKey(nameof(TaxPaymentVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTermId = group.Add(new VocabularyKey(nameof(PaymentTermId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodInterval = group.Add(new VocabularyKey(nameof(PeriodInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfUnit = group.Add(new VocabularyKey(nameof(NumberOfUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxAuthorityId = group.Add(new VocabularyKey(nameof(TaxAuthorityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FromDate { get; private set; }
public VocabularyKey TaxPeriodId { get; private set; }
public VocabularyKey ToDate { get; private set; }
public VocabularyKey TaxPaymentVersion { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey PaymentTermId { get; private set; }
public VocabularyKey PeriodInterval { get; private set; }
public VocabularyKey NumberOfUnit { get; private set; }
public VocabularyKey TaxAuthorityId { get; private set; }


    }
}