using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectTransferPriceEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectTransferPriceEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectTransferPriceEntity";
            KeyPrefix = "commonDataModel.projprojecttransferpriceentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectTransferPriceEntity";

            AddGroup("Common Data Model ProjProjectTransferPriceEntity Details", group =>
            {
                SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferPriceModel = group.Add(new VocabularyKey(nameof(TransferPriceModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BorrowingLegalEntity = group.Add(new VocabularyKey(nameof(BorrowingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContract = group.Add(new VocabularyKey(nameof(ProjectContract), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Project = group.Add(new VocabularyKey(nameof(Project), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Pricing = group.Add(new VocabularyKey(nameof(Pricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourcePersonnelNumber = group.Add(new VocabularyKey(nameof(ResourcePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCategoryId = group.Add(new VocabularyKey(nameof(ResourceCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SalesCurrency { get; private set; }
public VocabularyKey TransferPriceModel { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey BorrowingLegalEntity { get; private set; }
public VocabularyKey ProjectContract { get; private set; }
public VocabularyKey Project { get; private set; }
public VocabularyKey Resource { get; private set; }
public VocabularyKey ResourceCategory { get; private set; }
public VocabularyKey EffectiveDate { get; private set; }
public VocabularyKey Pricing { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey CategoryId { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey ProjectID { get; private set; }
public VocabularyKey ResourcePersonnelNumber { get; private set; }
public VocabularyKey ResourceCategoryId { get; private set; }


    }
}