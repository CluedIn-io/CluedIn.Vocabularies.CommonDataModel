using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectLinePropertyEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectLinePropertyEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjProjectLinePropertyEntity";
            KeyPrefix = "commonDataModel.projprojectlinepropertyentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectLinePropertyEntity";

            AddGroup("Common Data Model ProjProjectLinePropertyEntity Details", group =>
            {
                CostPercentage = group.Add(new VocabularyKey(nameof(CostPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddToEfficientHours = group.Add(new VocabularyKey(nameof(AddToEfficientHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LinePropertyId = group.Add(new VocabularyKey(nameof(LinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddToNormBillable = group.Add(new VocabularyKey(nameof(AddToNormBillable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddToNormEfficiency = group.Add(new VocabularyKey(nameof(AddToNormEfficiency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintZeroSalesPriceOnInvoice = group.Add(new VocabularyKey(nameof(PrintZeroSalesPriceOnInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrintZeroSalesPriceOnQuotation = group.Add(new VocabularyKey(nameof(PrintZeroSalesPriceOnQuotation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPercentage = group.Add(new VocabularyKey(nameof(SalesPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableAccrueRevenue = group.Add(new VocabularyKey(nameof(EnableAccrueRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnabledCapitalizeCost = group.Add(new VocabularyKey(nameof(EnabledCapitalizeCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsChargeable = group.Add(new VocabularyKey(nameof(IsChargeable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CostPercentage { get; private set; }
public VocabularyKey AddToEfficientHours { get; private set; }
public VocabularyKey LinePropertyId { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey AddToNormBillable { get; private set; }
public VocabularyKey AddToNormEfficiency { get; private set; }
public VocabularyKey PrintZeroSalesPriceOnInvoice { get; private set; }
public VocabularyKey PrintZeroSalesPriceOnQuotation { get; private set; }
public VocabularyKey SalesPercentage { get; private set; }
public VocabularyKey EnableAccrueRevenue { get; private set; }
public VocabularyKey EnabledCapitalizeCost { get; private set; }
public VocabularyKey IsChargeable { get; private set; }


    }
}