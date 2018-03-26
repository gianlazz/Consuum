using System;
using System.Collections.Generic;
using System.Text;

namespace Consuum.Core.ConfigurationSettings
{
    public class ConsuumSettings
    {
        /// <summary>
        /// USER ACCOUNT SETTINGS
        /// 
        /// Maybe a user auth token?
        /// Details on remaining in app purchased paid points towards premium services like improved cloud processing.
        /// 
        /// PREMIUM SETTINGS -- Should I have some kind of attribute or custom compliation for premium or basic?
        /// Cloud storage details
        /// How many to store? 
        /// Do they expire?
        /// Should it keep the original associated file or image?
        /// </summary>
        public UserSettings UserSettings { get; set; }
        /// <summary>
        /// RAPID SERIAL VISUAL PRESENTATION UI SETTINGS
        /// 
        /// Use default punction pausing config? || Don't Use at all?  --  This configuration might require it's own class.
        /// Pause at periods?
        /// Pause at commas?
        /// Pause at colons and semicolons?
        /// Pause duration?
        /// Use custom pause duration for each punctuation?
        /// 
        /// Text color?
        /// Text size?
        /// Wrap to second line?
        /// Show ghosting of previous and upcoming words?
        /// Animate the rendered movement over the original document?
        /// 
        /// </summary>
        public RsvpUISettings RsvpUISettings { get; set; }
        /// <summary>
        /// URL SETTINGS
        /// Search For Urls or maybe an entire class devoted to settings on the subject? Yeah it should be it's own class.
        /// Then I can have a page or section in the settings devoted to it also.
        /// 
        /// SETTING CONSIDERATIONS:
        /// Validate Urls?
        /// Attempt to autocorrect Urls via google lookup?
        /// Prompt User to select out of urls found?
        /// Keep associated undetermined potential Urls?
        /// </summary>
        public UrlParsingSettings UrlParsingSettings { get; set; }
        /// <summary>
        /// WEB SCRAPING REGEX SETTINGS
        /// 
        /// Remove links?
        /// Render links as links or resolve title?
        /// </summary>
        public WebScrapingSettings WebsScrapingSettings { get; set; }
        /// <summary>
        /// OCR SETTINGS
        /// 
        /// Local Tesseract or Google Cloud Vision etc? This will change dependency injection. -- This will consult with the user account
        /// </summary>
        public OcrSettings OcrSettings { get; set; }
        /// <summary>
        /// OBJECT DEFINITION
        /// --- A document is the result from the entire process including but not limited to:
        /// Original input Image after processing, Document, Url
        /// Associated Urls found from processing input
        /// Title
        /// DateTime Created
        /// TextAnnotation w/ x&y coordinates
        /// 
        /// DOCUMENT SETTINGS
        /// 
        /// Auto resolve document name/title by content lookup?
        /// </summary>
        public DocumentSettings DocumentSettings { get; set; }
    }
}
