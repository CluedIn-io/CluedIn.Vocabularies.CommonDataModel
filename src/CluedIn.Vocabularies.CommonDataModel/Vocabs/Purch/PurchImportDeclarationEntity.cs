using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchImportDeclarationEntityVocabulary : SimpleVocabulary
    {
        public PurchImportDeclarationEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchImportDeclarationEntity";
            KeyPrefix = "commonDataModel.purchimportdeclarationentity";
            KeySeparator = ".";
            Grouping = "/PurchImportDeclarationEntity";

            AddGroup("Common Data Model PurchImportDeclarationEntity Details", group =>
            {
                ImportDeclarationNumber = group.Add(new VocabularyKey(nameof(ImportDeclarationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImportDeclarationDate = group.Add(new VocabularyKey(nameof(ImportDeclarationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Port = group.Add(new VocabularyKey(nameof(Port), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ImportDeclarationType = group.Add(new VocabularyKey(nameof(ImportDeclarationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NationalizationDate = group.Add(new VocabularyKey(nameof(NationalizationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DrawBackNumber = group.Add(new VocabularyKey(nameof(DrawBackNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportMode = group.Add(new VocabularyKey(nameof(TransportMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AFRMM = group.Add(new VocabularyKey(nameof(AFRMM), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ImportDeclarationNumber { get; private set; }
public VocabularyKey ImportDeclarationDate { get; private set; }
public VocabularyKey Port { get; private set; }
public VocabularyKey ImportDeclarationType { get; private set; }
public VocabularyKey NationalizationDate { get; private set; }
public VocabularyKey DrawBackNumber { get; private set; }
public VocabularyKey TransportMode { get; private set; }
public VocabularyKey AFRMM { get; private set; }


    }
}