using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInfocodeEntity";
            KeyPrefix = "commonDataModel.retailinfocodeentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeEntity";

            AddGroup("Common Data Model RetailInfocodeEntity Details", group =>
            {
                InfocodeNumber = group.Add(new VocabularyKey(nameof(InfocodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputRequired = group.Add(new VocabularyKey(nameof(InputRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputType = group.Add(new VocabularyKey(nameof(InputType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LinkedInfocodeNumber = group.Add(new VocabularyKey(nameof(LinkedInfocodeNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumLength = group.Add(new VocabularyKey(nameof(MaximumLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumValue = group.Add(new VocabularyKey(nameof(MaximumValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumLength = group.Add(new VocabularyKey(nameof(MinimumLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumValue = group.Add(new VocabularyKey(nameof(MinimumValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OncePerTransaction = group.Add(new VocabularyKey(nameof(OncePerTransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintInputNameOnReceipt = group.Add(new VocabularyKey(nameof(PrintInputNameOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintInputOnReceipt = group.Add(new VocabularyKey(nameof(PrintInputOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintPromptOnReceipt = group.Add(new VocabularyKey(nameof(PrintPromptOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Prompt = group.Add(new VocabularyKey(nameof(Prompt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RandomCounter = group.Add(new VocabularyKey(nameof(RandomCounter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RandomFactor = group.Add(new VocabularyKey(nameof(RandomFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseInfocode = group.Add(new VocabularyKey(nameof(UseInfocode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Activity = group.Add(new VocabularyKey(nameof(Activity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMultiLineText = group.Add(new VocabularyKey(nameof(IsMultiLineText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintDescriptionOnReceipt = group.Add(new VocabularyKey(nameof(PrintDescriptionOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InfocodeNumber { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InputRequired { get; private set; }
        public VocabularyKey InputType { get; private set; }
        public VocabularyKey LinkedInfocodeNumber { get; private set; }
        public VocabularyKey MaximumLength { get; private set; }
        public VocabularyKey MaximumValue { get; private set; }
        public VocabularyKey MinimumLength { get; private set; }
        public VocabularyKey MinimumValue { get; private set; }
        public VocabularyKey OncePerTransaction { get; private set; }
        public VocabularyKey PrintInputNameOnReceipt { get; private set; }
        public VocabularyKey PrintInputOnReceipt { get; private set; }
        public VocabularyKey PrintPromptOnReceipt { get; private set; }
        public VocabularyKey Prompt { get; private set; }
        public VocabularyKey RandomCounter { get; private set; }
        public VocabularyKey RandomFactor { get; private set; }
        public VocabularyKey UseInfocode { get; private set; }
        public VocabularyKey Activity { get; private set; }
        public VocabularyKey IsMultiLineText { get; private set; }
        public VocabularyKey PrintDescriptionOnReceipt { get; private set; }


    }
}