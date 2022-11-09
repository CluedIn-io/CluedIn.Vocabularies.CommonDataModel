using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltyEarnSchemeLineEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltyEarnSchemeLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailLoyaltyEarnSchemeLineEntity";
            KeyPrefix = "commonDataModel.retailloyaltyearnschemelineentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltyEarnSchemeLineEntity";

            AddGroup("Common Data Model RetailLoyaltyEarnSchemeLineEntity Details", group =>
            {
                FromActivityAmountCurrency = group.Add(new VocabularyKey(nameof(FromActivityAmountCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromActivityAmountQty = group.Add(new VocabularyKey(nameof(FromActivityAmountQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromActivityRetailGroupMemberLine = group.Add(new VocabularyKey(nameof(FromActivityRetailGroupMemberLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromActivityType = group.Add(new VocabularyKey(nameof(FromActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyScheme = group.Add(new VocabularyKey(nameof(LoyaltyScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyTier = group.Add(new VocabularyKey(nameof(LoyaltyTier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToRewardPoint = group.Add(new VocabularyKey(nameof(ToRewardPoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToRewardPointAmountQty = group.Add(new VocabularyKey(nameof(ToRewardPointAmountQty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToRewardPointId = group.Add(new VocabularyKey(nameof(ToRewardPointId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltySchemeId = group.Add(new VocabularyKey(nameof(LoyaltySchemeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailLoyaltyTier_Affiliation = group.Add(new VocabularyKey(nameof(RetailLoyaltyTier_Affiliation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyTierId = group.Add(new VocabularyKey(nameof(LoyaltyTierId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoyaltyProgramName = group.Add(new VocabularyKey(nameof(LoyaltyProgramName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Color = group.Add(new VocabularyKey(nameof(Color), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Size = group.Add(new VocabularyKey(nameof(Size), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Style = group.Add(new VocabularyKey(nameof(Style), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfigId = group.Add(new VocabularyKey(nameof(ConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailAffiliationId = group.Add(new VocabularyKey(nameof(RetailAffiliationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AffiliationName = group.Add(new VocabularyKey(nameof(AffiliationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailFromOtherActivityTypeId = group.Add(new VocabularyKey(nameof(RetailFromOtherActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailFromOtherActivityType = group.Add(new VocabularyKey(nameof(RetailFromOtherActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceDataAreaId = group.Add(new VocabularyKey(nameof(SourceDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FromActivityAmountCurrency { get; private set; }
public VocabularyKey FromActivityAmountQty { get; private set; }
public VocabularyKey FromActivityRetailGroupMemberLine { get; private set; }
public VocabularyKey FromActivityType { get; private set; }
public VocabularyKey LoyaltyScheme { get; private set; }
public VocabularyKey LoyaltyTier { get; private set; }
public VocabularyKey ToRewardPoint { get; private set; }
public VocabularyKey ToRewardPointAmountQty { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey ToRewardPointId { get; private set; }
public VocabularyKey LoyaltySchemeId { get; private set; }
public VocabularyKey RetailLoyaltyTier_Affiliation { get; private set; }
public VocabularyKey LoyaltyTierId { get; private set; }
public VocabularyKey LoyaltyProgramName { get; private set; }
public VocabularyKey ItemId { get; private set; }
public VocabularyKey Color { get; private set; }
public VocabularyKey Size { get; private set; }
public VocabularyKey Style { get; private set; }
public VocabularyKey ConfigId { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }
public VocabularyKey CategoryName { get; private set; }
public VocabularyKey RetailAffiliationId { get; private set; }
public VocabularyKey AffiliationName { get; private set; }
public VocabularyKey RetailFromOtherActivityTypeId { get; private set; }
public VocabularyKey RetailFromOtherActivityType { get; private set; }
public VocabularyKey SourceDataAreaId { get; private set; }


    }
}