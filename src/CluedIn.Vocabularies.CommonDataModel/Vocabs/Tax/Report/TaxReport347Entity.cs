using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReport347EntityVocabulary : SimpleVocabulary
    {
        public TaxReport347EntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxReport347Entity";
            KeyPrefix = "commonDataModel.taxreport347entity";
            KeySeparator = ".";
            Grouping = "/TaxReport347Entity";

            AddGroup("Common Data Model TaxReport347Entity Details", group =>
            {
                Contact = group.Add(new VocabularyKey(nameof(Contact), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumOfTheDeclaration = group.Add(new VocabularyKey(nameof(DocumentNumOfTheDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAmount = group.Add(new VocabularyKey(nameof(MinimumAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumAmountOfPaymentsInCash = group.Add(new VocabularyKey(nameof(MinimumAmountOfPaymentsInCash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TableName = group.Add(new VocabularyKey(nameof(TableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreviousDeclarationNumber = group.Add(new VocabularyKey(nameof(PreviousDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentationType = group.Add(new VocabularyKey(nameof(PresentationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Replacement = group.Add(new VocabularyKey(nameof(Replacement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reported = group.Add(new VocabularyKey(nameof(Reported), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportedBy = group.Add(new VocabularyKey(nameof(ReportedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PresentaitionDate = group.Add(new VocabularyKey(nameof(PresentaitionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumberDeclaration = group.Add(new VocabularyKey(nameof(TaxExemptNumberDeclaration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalYear = group.Add(new VocabularyKey(nameof(FiscalYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfPurchase = group.Add(new VocabularyKey(nameof(NumberOfPurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfSales = group.Add(new VocabularyKey(nameof(NumberOfSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfPayment = group.Add(new VocabularyKey(nameof(NumberOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfPurchaseFromPublicEntity = group.Add(new VocabularyKey(nameof(NumberOfPurchaseFromPublicEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfSubventions = group.Add(new VocabularyKey(nameof(NumberOfSubventions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOfPurchase = group.Add(new VocabularyKey(nameof(AmountOfPurchase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOfSales = group.Add(new VocabularyKey(nameof(AmountOfSales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOfPayment = group.Add(new VocabularyKey(nameof(AmountOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOfPurchaseFromPublicEntity = group.Add(new VocabularyKey(nameof(AmountOfPurchaseFromPublicEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountOfSubventions = group.Add(new VocabularyKey(nameof(AmountOfSubventions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedDateAndTime = group.Add(new VocabularyKey(nameof(CreatedDateAndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountTenants = group.Add(new VocabularyKey(nameof(AmountTenants), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionTenants = group.Add(new VocabularyKey(nameof(CountryRegionTenants), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyTenants = group.Add(new VocabularyKey(nameof(CountyTenants), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Door = group.Add(new VocabularyKey(nameof(Door), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Entrance = group.Add(new VocabularyKey(nameof(Entrance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Floor = group.Add(new VocabularyKey(nameof(Floor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NameTenants = group.Add(new VocabularyKey(nameof(NameTenants), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Street = group.Add(new VocabularyKey(nameof(Street), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetNo = group.Add(new VocabularyKey(nameof(StreetNo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressAbbreviation = group.Add(new VocabularyKey(nameof(AddressAbbreviation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipPostalCode = group.Add(new VocabularyKey(nameof(ZipPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceOfEstate = group.Add(new VocabularyKey(nameof(ReferenceOfEstate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationCodeForTheBuildingProperty = group.Add(new VocabularyKey(nameof(LocationCodeForTheBuildingProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumberTrans = group.Add(new VocabularyKey(nameof(TaxExemptNumberTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountInCash = group.Add(new VocabularyKey(nameof(AmountInCash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountQuarter1 = group.Add(new VocabularyKey(nameof(AmountQuarter1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountQuarter2 = group.Add(new VocabularyKey(nameof(AmountQuarter2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountQuarter3 = group.Add(new VocabularyKey(nameof(AmountQuarter3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountQuarter4 = group.Add(new VocabularyKey(nameof(AmountQuarter4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountSettled = group.Add(new VocabularyKey(nameof(AmountSettled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpecialRegimeForCashAccountingMethod = group.Add(new VocabularyKey(nameof(SpecialRegimeForCashAccountingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceYearForCash = group.Add(new VocabularyKey(nameof(InvoiceYearForCash), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionTrans = group.Add(new VocabularyKey(nameof(CountryRegionTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyTrans = group.Add(new VocabularyKey(nameof(CountyTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Deposit = group.Add(new VocabularyKey(nameof(Deposit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsuranceProcess = group.Add(new VocabularyKey(nameof(InsuranceProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransName = group.Add(new VocabularyKey(nameof(TransName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskCode = group.Add(new VocabularyKey(nameof(TaskCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Tenancy = group.Add(new VocabularyKey(nameof(Tenancy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Representative = group.Add(new VocabularyKey(nameof(Representative), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReverseCharge = group.Add(new VocabularyKey(nameof(ReverseCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Contact { get; private set; }
        public VocabularyKey DocumentNumOfTheDeclaration { get; private set; }
        public VocabularyKey MinimumAmount { get; private set; }
        public VocabularyKey MinimumAmountOfPaymentsInCash { get; private set; }
        public VocabularyKey TableName { get; private set; }
        public VocabularyKey PreviousDeclarationNumber { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey PresentationType { get; private set; }
        public VocabularyKey Replacement { get; private set; }
        public VocabularyKey Reported { get; private set; }
        public VocabularyKey ReportedBy { get; private set; }
        public VocabularyKey PresentaitionDate { get; private set; }
        public VocabularyKey TaxExemptNumberDeclaration { get; private set; }
        public VocabularyKey FiscalYear { get; private set; }
        public VocabularyKey NumberOfPurchase { get; private set; }
        public VocabularyKey NumberOfSales { get; private set; }
        public VocabularyKey NumberOfPayment { get; private set; }
        public VocabularyKey NumberOfPurchaseFromPublicEntity { get; private set; }
        public VocabularyKey NumberOfSubventions { get; private set; }
        public VocabularyKey AmountOfPurchase { get; private set; }
        public VocabularyKey AmountOfSales { get; private set; }
        public VocabularyKey AmountOfPayment { get; private set; }
        public VocabularyKey AmountOfPurchaseFromPublicEntity { get; private set; }
        public VocabularyKey AmountOfSubventions { get; private set; }
        public VocabularyKey CreatedDateAndTime { get; private set; }
        public VocabularyKey AmountTenants { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegionTenants { get; private set; }
        public VocabularyKey CountyTenants { get; private set; }
        public VocabularyKey Door { get; private set; }
        public VocabularyKey Entrance { get; private set; }
        public VocabularyKey Floor { get; private set; }
        public VocabularyKey NameTenants { get; private set; }
        public VocabularyKey Street { get; private set; }
        public VocabularyKey StreetNo { get; private set; }
        public VocabularyKey AddressAbbreviation { get; private set; }
        public VocabularyKey ZipPostalCode { get; private set; }
        public VocabularyKey ReferenceOfEstate { get; private set; }
        public VocabularyKey LocationCodeForTheBuildingProperty { get; private set; }
        public VocabularyKey TaxExemptNumberTrans { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountInCash { get; private set; }
        public VocabularyKey AmountQuarter1 { get; private set; }
        public VocabularyKey AmountQuarter2 { get; private set; }
        public VocabularyKey AmountQuarter3 { get; private set; }
        public VocabularyKey AmountQuarter4 { get; private set; }
        public VocabularyKey AmountSettled { get; private set; }
        public VocabularyKey SpecialRegimeForCashAccountingMethod { get; private set; }
        public VocabularyKey InvoiceYearForCash { get; private set; }
        public VocabularyKey CountryRegionTrans { get; private set; }
        public VocabularyKey CountyTrans { get; private set; }
        public VocabularyKey Deposit { get; private set; }
        public VocabularyKey InsuranceProcess { get; private set; }
        public VocabularyKey TransName { get; private set; }
        public VocabularyKey TaskCode { get; private set; }
        public VocabularyKey Tenancy { get; private set; }
        public VocabularyKey Representative { get; private set; }
        public VocabularyKey ReverseCharge { get; private set; }


    }
}