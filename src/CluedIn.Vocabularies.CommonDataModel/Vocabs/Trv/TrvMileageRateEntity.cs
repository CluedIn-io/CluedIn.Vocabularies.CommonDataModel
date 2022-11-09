using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvMileageRateEntityVocabulary : SimpleVocabulary
    {
        public TrvMileageRateEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvMileageRateEntity";
            KeyPrefix = "commonDataModel.trvmileagerateentity";
            KeySeparator = ".";
            Grouping = "/TrvMileageRateEntity";

            AddGroup("Common Data Model TrvMileageRateEntity Details", group =>
            {
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpenseCategory = group.Add(new VocabularyKey(nameof(ExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateType = group.Add(new VocabularyKey(nameof(RateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VehicleType = group.Add(new VocabularyKey(nameof(VehicleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Rate { get; private set; }
public VocabularyKey ExpenseCategory { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey RateType { get; private set; }
public VocabularyKey ToDate { get; private set; }
public VocabularyKey VehicleType { get; private set; }


    }
}