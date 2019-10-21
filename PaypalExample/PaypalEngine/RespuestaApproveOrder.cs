using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaypalEngine
{
    public class RespuestaApproveOrder
    {
        public string viewName { get; set; }
        public bool production { get; set; }
        public bool isInlineUl { get; set; }
        public bool validateEmailFormat { get; set; }
        public bool isInjectedUl { get; set; }
        public string inlineUlSuffix { get; set; }
        public string flowExecutionUrl { get; set; }
        public string device { get; set; }
        public string coBrand { get; set; }
        public string signUpEndPoint { get; set; }
        public PageName pageName { get; set; }
        public ShowLogo showLogo { get; set; }
        public ShowFooter showFooter { get; set; }
        public string adsChallengeUrl { get; set; }
        public string clientName { get; set; }
        public string correlationId { get; set; }
        public bool isRtl { get; set; }
        public bool enableClientCalLogging { get; set; }
        public PasswordRecoveryFlow passwordRecoveryFlow { get; set; }
        public EmailRecoveryFlow emailRecoveryFlow { get; set; }
        public bool enableAdsCaptcha { get; set; }
        public FlowInfo flowInfo { get; set; }
        public string loginType { get; set; }
        public string rememberMeContentVersion { get; set; }
        public bool keepMeLoggedInEnabled { get; set; }
        public bool rememberMe { get; set; }
        public bool fnSyncDataEnabled { get; set; }
        public bool fnSyncTelemetryEnabled { get; set; }
        public bool enableFnBeaconOnWebViews { get; set; }
        public bool pwrFullPageRedirect { get; set; }
        public bool webAuthnFpIconEnabled { get; set; }
        public object profile { get; set; }
        public bool cookieBannerEnabled { get; set; }
        public bool isHybridLoginExperience { get; set; }
        public bool isTrackPasswordFieldAutoFillEnabled { get; set; }
        public bool splitLoginExperience { get; set; }
        public bool phonePasswordEnabled { get; set; }
        public bool phoneNotSetUp { get; set; }
        public List<CountryPhoneList> countryPhoneList { get; set; }
        public string phoneCode { get; set; }
        public string phone { get; set; }
        public bool lazyLoadCountryCodes { get; set; }
        public string splitLoginContext { get; set; }
        public string pageQualifier { get; set; }
        public string initialSplitLoginContext { get; set; }
        public bool hideSignupBtn { get; set; }
        public bool hidePwrOnRender { get; set; }
        public bool hidePwrOnEmailPage { get; set; }
        public bool hideSignupOnEmailPage { get; set; }
        public bool hideSignupOnPasswordPage { get; set; }
        public string layout { get; set; }
        public bool elementalDesign { get; set; }
        public bool spinnerWithLockIcon { get; set; }
        public string sessionID { get; set; }
        public string xoSDKScript { get; set; }
        public string oneTouchContentVersion { get; set; }
        public ContextualLogin contextualLogin { get; set; }
        public string requestUrl { get; set; }
        public FnBeaconData fnBeaconData { get; set; }
        public bool tpdSurveyEnabled { get; set; }
        public bool enableSmartlock { get; set; }
        public bool slShowOptInNotNow { get; set; }
        public string _csrf { get; set; }
        public bool enableAnalytics { get; set; }
        public int currentYear { get; set; }
        public UlSync ulSync { get; set; }
        public Sys sys { get; set; }

        public class PageName
        {
            public string page1 { get; set; }
            public string page2 { get; set; }
            public string pageError { get; set; }
        }

        public class ShowLogo
        {
            public string type { get; set; }
        }

        public class ShowFooter
        {
            public string type { get; set; }
        }

        public class PasswordRecoveryFlow
        {
            public string uri { get; set; }
        }

        public class EmailRecoveryFlow
        {
            public string uri { get; set; }
        }

        public class FlowInfo
        {
            public string returnUri { get; set; }
            public string state { get; set; }
            public string beaconClientMetaDataId { get; set; }
        }

        public class CountryPhoneList
        {
            public string __invalid_name__country { get; set; }
            public string __invalid_name__value { get; set; }
            public string __invalid_name__elt { get; set; }
            public string __invalid_name__code { get; set; }
        }

        public class Cart
        {
            public string amount { get; set; }
            public string currencySymbol { get; set; }
            public string currencyCode { get; set; }
            public string formattedCurrency { get; set; }
        }

        public class PrefillData
        {
            public string email { get; set; }
            public Cart cart { get; set; }
            public bool show { get; set; }
        }

        public class OnboardingData
        {
            public bool hide { get; set; }
            public string link { get; set; }
            public string contentKey { get; set; }
            public string trackingKey { get; set; }
            public int trackingValue { get; set; }
            public string accNoMatch { get; set; }
            public bool hideSignupOnEmailPage { get; set; }
            public bool hideSignupOnPasswordPage { get; set; }
        }

        public class MerchantData
        {
            public string name { get; set; }
            public string logoUrl { get; set; }
            public string cancelUrl { get; set; }
            public string targetCancelUrl { get; set; }
            public string paymentAction { get; set; }
            public string paymentToken { get; set; }
            public string merchantID { get; set; }
        }

        public class BackToCallerLink
        {
            public string contentKey { get; set; }
            public string url { get; set; }
        }

        public class AsyncPreLoadData
        {
            public string url { get; set; }
        }

        public class TagLine
        {
            public bool show { get; set; }
            public string contentKey { get; set; }
        }

        public class SubTagLine
        {
            public bool show { get; set; }
            public string contentKey { get; set; }
        }

        public class PwdSubTagLine
        {
            public bool show { get; set; }
            public string contentKey { get; set; }
        }

        public class IncontextData
        {
            public string version { get; set; }
            public string noBridge { get; set; }
            public string env { get; set; }
            public string icstage { get; set; }
        }

        public class PwdTagLine
        {
        }

        public class Treatment
        {
            public int experiment_id { get; set; }
            public int treatment_id { get; set; }
            public string treatment_name { get; set; }
        }

        public class PerformancePxp
        {
            public List<Treatment> treatments { get; set; }
            public string tracking_tags { get; set; }
        }

        public class ExperienceMetaData
        {
            public PrefillData prefillData { get; set; }
            public OnboardingData onboardingData { get; set; }
            public MerchantData merchantData { get; set; }
            public BackToCallerLink backToCallerLink { get; set; }
            public AsyncPreLoadData asyncPreLoadData { get; set; }
            public TagLine tagLine { get; set; }
            public SubTagLine subTagLine { get; set; }
            public PwdSubTagLine pwdSubTagLine { get; set; }
            public IncontextData incontextData { get; set; }
            public bool oneTouch { get; set; }
            public string oneTouchContentVersion { get; set; }
            public bool validateEmailFormat { get; set; }
            public bool elementalDesign { get; set; }
            public bool splitLogin { get; set; }
            public bool suppressXFrameOptions { get; set; }
            public bool postLoginInternalRedirect { get; set; }
            public bool ignorePaymentRequestApi { get; set; }
            public PwdTagLine pwdTagLine { get; set; }
            public PerformancePxp performancePxp { get; set; }
            public bool checkoutGdprPxp { get; set; }
        }

        public class Claims
        {
            public string ec_token { get; set; }
            public string referrer_account_number { get; set; }
        }

        public class Identity
        {
            public string targetClientId { get; set; }
            public string redirectUri { get; set; }
            public string oneTouchScope { get; set; }
            public Claims claims { get; set; }
        }

        public class Risk
        {
            public string fraudnetId { get; set; }
            public string riskEntryPoint { get; set; }
        }

        public class ServiceMetaData
        {
            public Identity identity { get; set; }
            public Risk risk { get; set; }
        }

        public class FormData
        {
            public string intent { get; set; }
            public string __invalid_name__ads_client_context { get; set; }
            public string flowId { get; set; }
            public string __invalid_name__ads_client_context_data { get; set; }
            public string ctxId2 { get; set; }
            public string requestUrl { get; set; }
            public bool forcePhonePasswordOptIn { get; set; }
        }

        public class Newaccount
        {
            public string label { get; set; }
        }

        public class Variant2
        {
            public string triggerOtpLogin { get; set; }
        }

        public class TenantTagLineContent
        {
            public string logIn { get; set; }
        }

        public class TenantSubTagLineContent
        {
            public string continueWith { get; set; }
        }

        public class TagLineContent
        {
            public string payWithPayPal { get; set; }
            public string payWithPayPalCredit { get; set; }
            public string loginToPayPal { get; set; }
            public string loginToPay { get; set; }
            public string payWithCard { get; set; }
            public string createAccount { get; set; }
            public string riskyLoginAddPhone { get; set; }
            public string riskyLoginAddShipping { get; set; }
            public string loginAddAddress { get; set; }
            public string riskyLoginUpdateCard { get; set; }
            public string riskyLoginAddCard { get; set; }
            public string loginAddCard { get; set; }
            public string riskyLoginShippingPassed { get; set; }
        }

        public class SubTagLineContent
        {
            public string enterEmail { get; set; }
            public string enterEmailOrPhone { get; set; }
            public string eligiblePurchase { get; set; }
            public string eligibleReturnPurchase { get; set; }
            public string specialFinancing { get; set; }
            public string addPhoneNumberConsent { get; set; }
            public string riskyLoginAddShippingST { get; set; }
            public string riskyLoginExpiredCardST { get; set; }
            public string riskyLoginShippingPassedST { get; set; }
        }

        public class SignupBtn
        {
            public string createAccount { get; set; }
            public string payWithCard { get; set; }
            public string payAsGuest { get; set; }
            public string checkoutAsGuest { get; set; }
        }

        public class BackToCaller
        {
            public string defaultLabel { get; set; }
        }

        public class EmailPage
        {
            public string paragraphText { get; set; }
            public string linkText { get; set; }
        }

        public class PasswordPage
        {
            public string paragraphText { get; set; }
            public string linkText { get; set; }
        }

        public class PayWithCard
        {
            public EmailPage emailPage { get; set; }
            public PasswordPage passwordPage { get; set; }
        }

        public class EmailPage2
        {
            public string paragraphText { get; set; }
            public string linkText { get; set; }
        }

        public class PasswordPage2
        {
            public string paragraphText { get; set; }
            public string linkText { get; set; }
        }

        public class CreateAccount
        {
            public EmailPage2 emailPage { get; set; }
            public PasswordPage2 passwordPage { get; set; }
        }

        public class SignUpLink
        {
            public PayWithCard payWithCard { get; set; }
            public CreateAccount createAccount { get; set; }
        }

        public class Pending
        {
            public string title { get; set; }
            public string title1 { get; set; }
            public string pageTitle { get; set; }
            public string message { get; set; }
            public string message1 { get; set; }
            public string message2 { get; set; }
            public string message3 { get; set; }
            public string message4 { get; set; }
            public string message5 { get; set; }
            public string resendMsgClick { get; set; }
            public string tryAnotherClick { get; set; }
            public string notYou { get; set; }
            public string sent { get; set; }
            public string usePasswordReason1 { get; set; }
            public string usePasswordReason2 { get; set; }
            public string usePasswordReason3 { get; set; }
            public string usePasswordReason4 { get; set; }
            public string usePasswordReason5 { get; set; }
            public string goToAppButton { get; set; }
        }

        public class Denied
        {
            public string title { get; set; }
            public string message { get; set; }
        }

        public class Expired
        {
            public string pageTitle { get; set; }
            public string heading { get; set; }
            public string descriptionLine1 { get; set; }
            public string actionText { get; set; }
        }

        public class Content
        {
            public string title { get; set; }
            public string pageTitle { get; set; }
            public string titleThirdPartyLogin { get; set; }
            public string pageTitleThirdPartyLogin { get; set; }
            public string titleError { get; set; }
            public string emailLabel { get; set; }
            public string passwordLabel { get; set; }
            public Newaccount newaccount { get; set; }
            public string button { get; set; }
            public string buttonNext { get; set; }
            public string emailRequired { get; set; }
            public string emailInvalid { get; set; }
            public string passwordRequired { get; set; }
            public string emailOrPhoneLabel { get; set; }
            public string emailOrPhoneRequired { get; set; }
            public string emailOrPhoneInvalid { get; set; }
            public string phoneCodeLabel { get; set; }
            public string phoneLabel { get; set; }
            public string phoneButton { get; set; }
            public string emailButton { get; set; }
            public string pinLabel { get; set; }
            public string phoneRequired { get; set; }
            public string phoneInvalid { get; set; }
            public string pinRequired { get; set; }
            public string clearEmail { get; set; }
            public string clearPassword { get; set; }
            public string forgotPassword { get; set; }
            public string forgotPasswordBubble { get; set; }
            public string moreOptions { get; set; }
            public string moreOptionsMobile { get; set; }
            public string moreOptionsMobile1 { get; set; }
            public string tpdDemoMessage { get; set; }
            public string triggerOtpLogin { get; set; }
            public Variant2 variant2 { get; set; }
            public string showPassword { get; set; }
            public string hidePassword { get; set; }
            public string showPasswordLabel { get; set; }
            public string hidePasswordLabel { get; set; }
            public string showPinLabel { get; set; }
            public string hidePinLabel { get; set; }
            public string close { get; set; }
            public string keepMeLoggedIn { get; set; }
            public string keepMeLoggedInAbout { get; set; }
            public string keepMeLoggedInTitle { get; set; }
            public string stayLoggedIn { get; set; }
            public string skipLogin { get; set; }
            public string doNotRecommend { get; set; }
            public string disableStayLogin { get; set; }
            public string closeAboutStayLogin { get; set; }
            public List<string> keepMeLoggedInLabel { get; set; }
            public List<string> keepMeLoggedInAboutTitle { get; set; }
            public List<string> keepMeLoggedInAboutAnchor { get; set; }
            public List<string> aboutKeepMeLoggedInHeader { get; set; }
            public List<string> aboutKeepMeLoggedInDescriptionLine1 { get; set; }
            public List<string> aboutKeepMeLoggedInDescriptionLine2 { get; set; }
            public List<string> aboutKeepMeLoggedInDescriptionLine3 { get; set; }
            public List<string> closeKeepMeLoggedIn { get; set; }
            public List<string> keepMeLoggedInTagLine { get; set; }
            public List<string> aboutKeepMeLoggedInDescriptionLine4 { get; set; }
            public string notYou { get; set; }
            public string tryPasswordlessButton { get; set; }
            public string rememberProfileLabel { get; set; }
            public string moreInfo { get; set; }
            public string rememberProfileInfo { get; set; }
            public string educationMessageLine1 { get; set; }
            public string educationMessageLine2 { get; set; }
            public string educationMessage1 { get; set; }
            public string educationMessage2 { get; set; }
            public string educationMessage3 { get; set; }
            public string educationSwitchLink { get; set; }
            public string educationTryItLink { get; set; }
            public string educationTakeMeBack { get; set; }
            public string retiringPhonePin { get; set; }
            public string secureWindowMsg { get; set; }
            public string loginSigupSeparator { get; set; }
            public string processingMsg { get; set; }
            public string fpLoginHeading { get; set; }
            public string fpLoginUsePassword { get; set; }
            public string fpLoginError { get; set; }
            public string pleaseTryAgain { get; set; }
            public string slHeading { get; set; }
            public string slDescription1 { get; set; }
            public string loginWithEmail { get; set; }
            public string loginWithPhone { get; set; }
            public string change { get; set; }
            public string passwordPinLabel { get; set; }
            public string phoneNotSetUpForLogin { get; set; }
            public string subTagLinePhone { get; set; }
            public string oneTouchSubHeading { get; set; }
            public string reactivateOneTouch { get; set; }
            public string sessionTimeOut { get; set; }
            public string cancelAndReturnLabel { get; set; }
            public string keychainActivation8ball { get; set; }
            public string keychainActivationBlockedOnRiskyLogin { get; set; }
            public string keychainActivationFailure { get; set; }
            public TenantTagLineContent tenantTagLineContent { get; set; }
            public TenantSubTagLineContent tenantSubTagLineContent { get; set; }
            public string returnLabel { get; set; }
            public TagLineContent tagLineContent { get; set; }
            public SubTagLineContent subTagLineContent { get; set; }
            public SignupBtn signupBtn { get; set; }
            public string merchant { get; set; }
            public BackToCaller backToCaller { get; set; }
            public string forgotEmailLinkText { get; set; }
            public string forgotPasswordLinkText { get; set; }
            public SignUpLink signUpLink { get; set; }
            public string labelCaptcha { get; set; }
            public string imgAltText { get; set; }
            public string reloadimage { get; set; }
            public string audiobutton { get; set; }
            public string emptyCaptcha { get; set; }
            public string clearCaptcha { get; set; }
            public Pending pending { get; set; }
            public Denied denied { get; set; }
            public Expired expired { get; set; }
            public string tagLine { get; set; }
            public string pwdSubTagLine { get; set; }
            public string subTagLine { get; set; }
        }

        public class SupportedLocaleList
        {
            public string __invalid_name__countryCode { get; set; }
            public string __invalid_name__localeCode { get; set; }
            public string __invalid_name__languageCode { get; set; }
            public string __invalid_name__localeLabel { get; set; }
            public bool __invalid_name__selected { get; set; }
        }

        public class IntentFooter
        {
            public List<SupportedLocaleList> supportedLocaleList { get; set; }
        }

        public class IntentHeader
        {
        }

        public class SignUpButton
        {
            public string content { get; set; }
            public string url { get; set; }
        }

        public class IncontextData2
        {
            public string version { get; set; }
            public string noBridge { get; set; }
            public string env { get; set; }
            public string icstage { get; set; }
        }

        public class ContextualLogin
        {
            public string intent { get; set; }
            public string appName { get; set; }
            public string flowName { get; set; }
            public ExperienceMetaData experienceMetaData { get; set; }
            public ServiceMetaData serviceMetaData { get; set; }
            public FormData formData { get; set; }
            public Content content { get; set; }
            public IntentFooter intentFooter { get; set; }
            public IntentHeader intentHeader { get; set; }
            public object tracking { get; set; }
            public string flowId { get; set; }
            public string fraudnetId { get; set; }
            public string paymentAction { get; set; }
            public string paymentToken { get; set; }
            public string merchantID { get; set; }
            public string claims { get; set; }
            public bool enableOneTouch { get; set; }
            public bool supXFO { get; set; }
            public SignUpButton signUpButton { get; set; }
            public IncontextData2 incontextData { get; set; }
        }

        public class FnBeaconData
        {
            public string fnSessionId { get; set; }
            public string sourceId { get; set; }
            public string fnUrl { get; set; }
            public string beaconUrl { get; set; }
            public bool enableSpeedTyping { get; set; }
        }

        public class UlSync
        {
            public string sourceId { get; set; }
            public string fnSessionId { get; set; }
        }

        public class Links
        {
            public string jsBaseUrl { get; set; }
            public string cssBaseUrl { get; set; }
            public string templateBaseUrl { get; set; }
            public string resourceBaseUrl { get; set; }
            public string originalTemplateBaseUrl { get; set; }
        }

        public class PageInfo
        {
            public string date { get; set; }
            public string hostName { get; set; }
            public string rlogId { get; set; }
            public string script { get; set; }
            public object debug { get; set; }
        }

        public class Timezone
        {
            public string determiner { get; set; }
            public string value { get; set; }
        }

        public class Locality
        {
            public Timezone timezone { get; set; }
            public string country { get; set; }
            public string locale { get; set; }
            public string language { get; set; }
            public string directionality { get; set; }
        }

        public class Links2
        {
            public string privacy { get; set; }
            public string home { get; set; }
        }

        public class Messages
        {
            public string copyright { get; set; }
        }

        public class IdentityFooter
        {
            public Links2 links { get; set; }
            public Messages messages { get; set; }
        }

        public class Fpti
        {
            public string name { get; set; }
            public string jsURL { get; set; }
            public string serverURL { get; set; }
            public string dataString { get; set; }
        }

        public class Tracking
        {
            public Fpti fpti { get; set; }
        }

        public class Sys
        {
            public Links links { get; set; }
            public PageInfo pageInfo { get; set; }
            public Locality locality { get; set; }
            public IdentityFooter identityFooter { get; set; }
            public Tracking tracking { get; set; }
        }
    }
}