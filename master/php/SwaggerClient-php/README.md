# SwaggerClient-php
To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.

This PHP package is automatically generated by the [Swagger Codegen](https://github.com/swagger-api/swagger-codegen) project:

- API version: 1.0b
- Package version: 
- Build date: 2016-07-16T19:11:25.371Z
- Build package: class io.swagger.codegen.languages.PhpClientCodegen

## Requirements

PHP 5.4.0 and later

## Installation & Usage
### Composer

To install the bindings via [Composer](http://getcomposer.org/), add the following to `composer.json`:

```
{
  "repositories": [
    {
      "type": "git",
      "url": "https://github.com//.git"
    }
  ],
  "require": {
    "/": "*@dev"
  }
}
```

Then run `composer install`

### Manual Installation

Download the files and include `autoload.php`:

```php
    require_once('/path/to/SwaggerClient-php/autoload.php');
```

## Tests

To run the unit tests:

```
composer install
./vendor/bin/phpunit lib/Tests
```

## Getting Started

Please follow the [installation procedure](#installation--usage) and then run the following:

```php
<?php
require_once(__DIR__ . '/vendor/autoload.php');

$api_instance = new Swagger\Client\Api\AccountActionsApi();
$body = new \Swagger\Client\Model\LoginFormNew(); // \Swagger\Client\Model\LoginFormNew | Please send the form with valid inputs.
$accept = "accept_example"; // string | JSON, XML or CSV can be returned (Optional)

try {
    $result = $api_instance->v1login($body, $accept);
    print_r($result);
} catch (Exception $e) {
    echo 'Exception when calling AccountActionsApi->v1login: ', $e->getMessage(), PHP_EOL;
}

?>
```

## Documentation for API Endpoints

All URIs are relative to *https://api.coinsecure.in/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountActionsApi* | [**v1login**](docs/Api/AccountActionsApi.md#v1login) | **POST** /v1/login | Creates a Login Instance and returns an API Key.
*AccountActionsApi* | [**v1logininitiate**](docs/Api/AccountActionsApi.md#v1logininitiate) | **POST** /v1/login/initiate | Initiate Login
*AccountActionsApi* | [**v1loginpasswordforgot**](docs/Api/AccountActionsApi.md#v1loginpasswordforgot) | **POST** /v1/login/password/forgot | Sends an email with a password reset token
*AccountActionsApi* | [**v1signup**](docs/Api/AccountActionsApi.md#v1signup) | **POST** /v1/signup | Creates a new Unverified Account.
*AccountActionsApi* | [**v1userbankotpNumber**](docs/Api/AccountActionsApi.md#v1userbankotpnumber) | **GET** /v1/user/bank/otp/{number} | Send OTP for Bank Link
*AccountActionsApi* | [**v1userexchangekyc**](docs/Api/AccountActionsApi.md#v1userexchangekyc) | **PUT** /v1/user/exchange/kyc | Submits a New Bank Link and initial KYC Documents.
*AccountActionsApi* | [**v1usergcmCode**](docs/Api/AccountActionsApi.md#v1usergcmcode) | **DELETE** /v1/user/gcm/{code} | Delete GCM Code
*AccountActionsApi* | [**v1userkycotpNumber**](docs/Api/AccountActionsApi.md#v1userkycotpnumber) | **GET** /v1/user/kyc/otp/{number} | Send OTP for KYC Link
*AccountActionsApi* | [**v1userlogout**](docs/Api/AccountActionsApi.md#v1userlogout) | **DELETE** /v1/user/logout | Logout User
*AccountActionsApi* | [**v1usernetkicreate**](docs/Api/AccountActionsApi.md#v1usernetkicreate) | **PUT** /v1/user/netki/create | Create Neki Wallet Name
*AccountActionsApi* | [**v1usernetkiupdate**](docs/Api/AccountActionsApi.md#v1usernetkiupdate) | **PATCH** /v1/user/netki/update | Update Netki Address
*AccountActionsApi* | [**v1userprofileimagedelete**](docs/Api/AccountActionsApi.md#v1userprofileimagedelete) | **POST** /v1/user/contact | Delete Profile Image
*AccountActionsApi* | [**v1userprofileimageupdate**](docs/Api/AccountActionsApi.md#v1userprofileimageupdate) | **PATCH** /v1/user/profile/image/update | Update Profile Image
*AccountActionsApi* | [**v1userprofilephone**](docs/Api/AccountActionsApi.md#v1userprofilephone) | **PUT** /v1/user/profile/phone/new | New Profile Phone
*AccountActionsApi* | [**v1userprofilephoneNumber**](docs/Api/AccountActionsApi.md#v1userprofilephonenumber) | **DELETE** /v1/user/profile/phone/delete | Delete Profile Phone Number
*AccountActionsApi* | [**v1userprofilephoneotpNumber**](docs/Api/AccountActionsApi.md#v1userprofilephoneotpnumber) | **GET** /v1/user/profile/phone/otp/{number} | Send OTP for Profile Phone
*AccountDataApi* | [**v1exchangebanksummary**](docs/Api/AccountDataApi.md#v1exchangebanksummary) | **GET** /v1/user/exchange/bank/summary | Exchange Bank Summary
*AccountDataApi* | [**v1exchangeusercoinfee**](docs/Api/AccountDataApi.md#v1exchangeusercoinfee) | **GET** /v1/user/exchange/coin/fee | Users Coin Fee Percentage
*AccountDataApi* | [**v1exchangeuserfiatfee**](docs/Api/AccountDataApi.md#v1exchangeuserfiatfee) | **GET** /v1/user/exchange/fiat/fee | Users Fiat Fee Percentage
*AccountDataApi* | [**v1netkisearchNetkiName**](docs/Api/AccountDataApi.md#v1netkisearchnetkiname) | **GET** /v1/netki/search/{netkiName} | Coinsecure.me Netki Lookup
*AccountDataApi* | [**v1userexchangekycs**](docs/Api/AccountDataApi.md#v1userexchangekycs) | **GET** /v1/user/exchange/kycs | Gets KYC Status Details
*AccountDataApi* | [**v1userexchangereferralcoinpaid**](docs/Api/AccountDataApi.md#v1userexchangereferralcoinpaid) | **GET** /v1/user/exchange/referral/coin/paid | Users Paid Fiat Referrals
*AccountDataApi* | [**v1userexchangereferralcoinsuccessful**](docs/Api/AccountDataApi.md#v1userexchangereferralcoinsuccessful) | **GET** /v1/user/exchange/referral/coin/successful | Gets Users Successful Referral Links
*AccountDataApi* | [**v1userexchangereferralfiatpaid**](docs/Api/AccountDataApi.md#v1userexchangereferralfiatpaid) | **GET** /v1/user/exchange/referral/fiat/paid | Users Paid Fiat Referrals
*AccountDataApi* | [**v1userexchangereferrals**](docs/Api/AccountDataApi.md#v1userexchangereferrals) | **GET** /v1/user/exchange/referrals | Gets Users Referral Links
*AccountDataApi* | [**v1userexchangetradesummary**](docs/Api/AccountDataApi.md#v1userexchangetradesummary) | **GET** /v1/user/exchange/trade/summary | Exchange Trade Summary
*AccountDataApi* | [**v1userlogintokenToken**](docs/Api/AccountDataApi.md#v1userlogintokentoken) | **GET** /v1/user/login/token/{token} | Login Token Email
*AccountDataApi* | [**v1usersummary**](docs/Api/AccountDataApi.md#v1usersummary) | **GET** /v1/user/summary | Exchange Bank Summary
*AccountDataApi* | [**v1userwalletsummary**](docs/Api/AccountDataApi.md#v1userwalletsummary) | **GET** /v1/user/wallet/summary | Exchange Bank Summary
*BlockchainToolsApi* | [**v1bitcoinsearchAddress**](docs/Api/BlockchainToolsApi.md#v1bitcoinsearchaddress) | **GET** /v1/bitcoin/search/{any} | Search Bitcoin Blockchain
*BlockchainToolsApi* | [**v1bitcoinsearchTxid**](docs/Api/BlockchainToolsApi.md#v1bitcoinsearchtxid) | **GET** /v1/bitcoin/search/confirmation/{txid} | Get Confirmations
*ExchangeBankActionsApi* | [**v1userexchangebankcoinwithdrawinitiate**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawinitiate) | **POST** /v1/user/exchange/bank/coin/withdraw/initiate | Initiate Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**v1userexchangebankcoinwithdrawnewVerifycode**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawnewverifycode) | **POST** /v1/user/exchange/bank/coin/withdraw/newVerifycode | Gets a Verification Code.
*ExchangeBankActionsApi* | [**v1userexchangebankcoinwithdrawunverifiedcancel**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawunverifiedcancel) | **DELETE** /v1/user/exchange/bank/coin/withdraw/unverified/cancel | Cancel Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**v1userexchangebankcoinwithdrawverify**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawverify) | **PUT** /v1/user/exchange/bank/coin/withdraw/verify | Verify Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**v1userexchangebankfiataccountnew**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiataccountnew) | **PUT** /v1/user/exchange/bank/fiat/account/new | New Bank Link
*ExchangeBankActionsApi* | [**v1userexchangebankfiatdepositcancel**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatdepositcancel) | **DELETE** /v1/user/exchange/bank/fiat/deposit/cancel | Cancel Unverified Exchange Fiat Deposit
*ExchangeBankActionsApi* | [**v1userexchangebankfiatdepositnew**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatdepositnew) | **PUT** /v1/user/exchange/bank/fiat/deposit/new | New Exchange Fiat Deposit
*ExchangeBankActionsApi* | [**v1userexchangebankfiatwithdrawinitiate**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawinitiate) | **POST** /v1/user/exchange/bank/fiat/withdraw/initiate | Initiate Fiat Withdrawal
*ExchangeBankActionsApi* | [**v1userexchangebankfiatwithdrawnewVerifycode**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawnewverifycode) | **POST** /v1/user/exchange/bank/fiat/withdraw/newVerifycode | Gets a Fiat Verification Code.
*ExchangeBankActionsApi* | [**v1userexchangebankfiatwithdrawunverifiedcancel**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawunverifiedcancel) | **DELETE** /v1/user/exchange/bank/fiat/withdraw/unverified/cancel | Cancel Fiat Withdrawal
*ExchangeBankActionsApi* | [**v1userexchangebankfiatwithdrawverify**](docs/Api/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawverify) | **PUT** /v1/user/exchange/bank/fiat/withdraw/verify | Verify Fiat Withdrawal
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinaddresses**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinaddresses) | **GET** /v1/user/exchange/bank/coin/addresses | Exchange Coin Addresses
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinbalanceavailable**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalanceavailable) | **GET** /v1/user/exchange/bank/coin/balance/total | Available Exchange Coin Balance
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinbalancepending**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalancepending) | **GET** /v1/user/exchange/bank/coin/balance/pending | In Trade Coin Balance
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinbalancetotal**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalancetotal) | **GET** /v1/user/exchange/bank/coin/balance/available | Total Exchange Coin Balance
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoindepositcancelled**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositcancelled) | **GET** /v1/user/exchange/bank/coin/deposit/cancelled | Cancelled Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoindepositunverified**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositunverified) | **GET** /v1/user/exchange/bank/coin/deposit/unverified | Unverified Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoindepositverified**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositverified) | **GET** /v1/user/exchange/bank/coin/deposit/verified | Verified Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinwithdrawcancelled**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawcancelled) | **GET** /v1/user/exchange/bank/coin/withdraw/cancelled | Cancelled Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinwithdrawcompleted**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawcompleted) | **GET** /v1/user/exchange/bank/coin/withdraw/completed | Completed Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinwithdrawunverified**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawunverified) | **GET** /v1/user/exchange/bank/coin/withdraw/unverified | Unverified Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**v1userexchangebankcoinwithdrawverified**](docs/Api/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawverified) | **GET** /v1/user/exchange/bank/coin/withdraw/verified | Verified Exchange Coin Withdrawals
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiataccounts**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiataccounts) | **GET** /v1/user/exchange/bank/fiat/accounts | Exchange Bitcoin Deposit Addresses
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatbalanceavailable**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalanceavailable) | **GET** /v1/user/exchange/bank/fiat/balance/total | Available Exchange Fiat Balance
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatbalancepending**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalancepending) | **GET** /v1/user/exchange/bank/fiat/balance/pending | In Trade Coin Balance
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatbalancetotal**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalancetotal) | **GET** /v1/user/exchange/bank/fiat/balance/available | Total Exchange Fiat Balance
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatdepositcancelled**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositcancelled) | **GET** /v1/user/exchange/bank/fiat/deposit/cancelled | Cancelled Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatdepositunverified**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositunverified) | **GET** /v1/user/exchange/bank/fiat/deposit/unverified | Unverified Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatdepositverified**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositverified) | **GET** /v1/user/exchange/bank/fiat/deposit/verified | Verified Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatwithdrawcancelled**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawcancelled) | **GET** /v1/user/exchange/bank/fiat/withdraw/cancelled | Cancelled Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatwithdrawcompleted**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawcompleted) | **GET** /v1/user/exchange/bank/fiat/withdraw/completed | Completed Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatwithdrawunverified**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawunverified) | **GET** /v1/user/exchange/bank/fiat/withdraw/unverified | Unverified Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**v1userexchangebankfiatwithdrawverified**](docs/Api/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawverified) | **GET** /v1/user/exchange/bank/fiat/withdraw/verified | Verified Exchange Fiat Withdrawals
*ExchangeTradeActionsApi* | [**v1userexchangeaskcancel**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangeaskcancel) | **DELETE** /v1/user/exchange/ask/cancel | Cancel Open Sell Order
*ExchangeTradeActionsApi* | [**v1userexchangeasknew**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangeasknew) | **PUT** /v1/user/exchange/ask/new | BTC Sell Order
*ExchangeTradeActionsApi* | [**v1userexchangebidcancel**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangebidcancel) | **DELETE** /v1/user/exchange/bid/cancel | Cancel Open Buy Order
*ExchangeTradeActionsApi* | [**v1userexchangebidnew**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangebidnew) | **PUT** /v1/user/exchange/bid/new | BTC Buy Order
*ExchangeTradeActionsApi* | [**v1userexchangeinstantbuy**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangeinstantbuy) | **PUT** /v1/user/exchange/instant/buy | Instantly Buy BTC
*ExchangeTradeActionsApi* | [**v1userexchangeinstantsell**](docs/Api/ExchangeTradeActionsApi.md#v1userexchangeinstantsell) | **PUT** /v1/user/exchange/instant/sell | Instantly Sell BTC
*ExchangeTradeDataApi* | [**v1exchangeasklow**](docs/Api/ExchangeTradeDataApi.md#v1exchangeasklow) | **GET** /v1/exchange/ask/low | Lowest Ask
*ExchangeTradeDataApi* | [**v1exchangeaskorders**](docs/Api/ExchangeTradeDataApi.md#v1exchangeaskorders) | **GET** /v1/exchange/ask/orders | All Sell Orders
*ExchangeTradeDataApi* | [**v1exchangebidhigh**](docs/Api/ExchangeTradeDataApi.md#v1exchangebidhigh) | **GET** /v1/exchange/bid/high | Returns the Highest Bid in the Order Book
*ExchangeTradeDataApi* | [**v1exchangebidorders**](docs/Api/ExchangeTradeDataApi.md#v1exchangebidorders) | **GET** /v1/exchange/bid/orders | All Buy Orders
*ExchangeTradeDataApi* | [**v1exchangelastTrade**](docs/Api/ExchangeTradeDataApi.md#v1exchangelasttrade) | **GET** /v1/exchange/lastTrade | Last Trade
*ExchangeTradeDataApi* | [**v1exchangemax24Hr**](docs/Api/ExchangeTradeDataApi.md#v1exchangemax24hr) | **GET** /v1/exchange/max24Hr | Max 24 Hour Rate
*ExchangeTradeDataApi* | [**v1exchangemin24Hr**](docs/Api/ExchangeTradeDataApi.md#v1exchangemin24hr) | **GET** /v1/exchange/min24Hr | Min 24 Hour Rate
*ExchangeTradeDataApi* | [**v1exchangeticker**](docs/Api/ExchangeTradeDataApi.md#v1exchangeticker) | **GET** /v1/exchange/ticker | Exchange Ticker
*ExchangeTradeDataApi* | [**v1userexchangeaskcancelled**](docs/Api/ExchangeTradeDataApi.md#v1userexchangeaskcancelled) | **GET** /v1/user/exchange/ask/cancelled | Cancelled User Sell Orders
*ExchangeTradeDataApi* | [**v1userexchangeaskcompleted**](docs/Api/ExchangeTradeDataApi.md#v1userexchangeaskcompleted) | **GET** /v1/user/exchange/ask/completed | Completed User Sell Orders
*ExchangeTradeDataApi* | [**v1userexchangeaskpending**](docs/Api/ExchangeTradeDataApi.md#v1userexchangeaskpending) | **GET** /v1/user/exchange/ask/pending | Pending User Sell Orders
*ExchangeTradeDataApi* | [**v1userexchangebidcancelled**](docs/Api/ExchangeTradeDataApi.md#v1userexchangebidcancelled) | **GET** /v1/user/exchange/bid/cancelled | Cancelled User Buy Orders
*ExchangeTradeDataApi* | [**v1userexchangebidcompleted**](docs/Api/ExchangeTradeDataApi.md#v1userexchangebidcompleted) | **GET** /v1/user/exchange/bid/completed | Completed User Buy Orders
*ExchangeTradeDataApi* | [**v1userexchangebidpending**](docs/Api/ExchangeTradeDataApi.md#v1userexchangebidpending) | **GET** /v1/user/exchange/bid/pending | Pending User Buy Orders
*SecurityActionsApi* | [**v1mfaauthyinitiate**](docs/Api/SecurityActionsApi.md#v1mfaauthyinitiate) | **POST** /v1/mfa/authy/initiate | Initiate Authy Registration.
*SecurityActionsApi* | [**v1mfagainitiate**](docs/Api/SecurityActionsApi.md#v1mfagainitiate) | **POST** /v1/mfa/ga/initiate | Initiate GA Registration.
*SecurityActionsApi* | [**v1usermfaauthycall**](docs/Api/SecurityActionsApi.md#v1usermfaauthycall) | **GET** /v1/mfa/authy/call | Authy Call Code
*SecurityActionsApi* | [**v1usermfaauthydisable**](docs/Api/SecurityActionsApi.md#v1usermfaauthydisable) | **DELETE** /v1/user/mfa/authy/disable | Disable Authy
*SecurityActionsApi* | [**v1usermfaauthyinitiateenable**](docs/Api/SecurityActionsApi.md#v1usermfaauthyinitiateenable) | **PUT** /v1/user/mfa/authy/initiate/enable | Verify Authy Registration
*SecurityActionsApi* | [**v1usermfaauthysms**](docs/Api/SecurityActionsApi.md#v1usermfaauthysms) | **GET** /v1/mfa/authy/sms | Authy Sms Code
*SecurityActionsApi* | [**v1usermfagadisable**](docs/Api/SecurityActionsApi.md#v1usermfagadisable) | **DELETE** /v1/user/mfa/ga/disable | Disable Google Authenticator
*SecurityActionsApi* | [**v1usermfagainitiateenable**](docs/Api/SecurityActionsApi.md#v1usermfagainitiateenable) | **PUT** /v1/user/mfa/ga/initiate/enable | Enable Google Authenticator
*SecurityActionsApi* | [**v1userpasswordchange**](docs/Api/SecurityActionsApi.md#v1userpasswordchange) | **PATCH** /v1/user/password/change | Change Password.
*SecurityActionsApi* | [**v1userpasswordreset**](docs/Api/SecurityActionsApi.md#v1userpasswordreset) | **PATCH** /v1/user/password/reset | Reset Password.
*WalletActionsApi* | [**v1userwalletcoinaddressnew**](docs/Api/WalletActionsApi.md#v1userwalletcoinaddressnew) | **PUT** /v1/user/wallet/coin/address/new | New Bitcoin Address
*WalletActionsApi* | [**v1userwalletcoinnew**](docs/Api/WalletActionsApi.md#v1userwalletcoinnew) | **PUT** /v1/user/wallet/coin/new | Create New Wallet
*WalletActionsApi* | [**v1userwalletcoinwithdrawinitiate**](docs/Api/WalletActionsApi.md#v1userwalletcoinwithdrawinitiate) | **POST** /v1/user/wallet/coin/withdraw/initiate | Initiate Bitcoin Withdrawal
*WalletActionsApi* | [**v1userwalletcoinwithdrawsendToExchange**](docs/Api/WalletActionsApi.md#v1userwalletcoinwithdrawsendtoexchange) | **PUT** /v1/user/wallet/coin/withdraw/sendToExchange | Send to Exchange
*WalletActionsApi* | [**v1userwalletcoinwithdrawunverifiedcancel**](docs/Api/WalletActionsApi.md#v1userwalletcoinwithdrawunverifiedcancel) | **DELETE** /v1/user/wallet/coin/withdraw/unverified/cancel | Cancel Bitcoin Withdrawal
*WalletActionsApi* | [**v1userwalletcoinwithdrawverify**](docs/Api/WalletActionsApi.md#v1userwalletcoinwithdrawverify) | **PUT** /v1/user/wallet/coin/withdraw/verify | Verify Bitcoin Withdrawal
*WalletActionsApi* | [**v1walletcoinwithdrawnewVerifycode**](docs/Api/WalletActionsApi.md#v1walletcoinwithdrawnewverifycode) | **POST** /v1/wallet/coin/withdraw/newVerifycode | Gets a Verification Code
*WalletDataApi* | [**v1userwalletcoinaddressWalletID**](docs/Api/WalletDataApi.md#v1userwalletcoinaddresswalletid) | **GET** /v1/user/wallet/coin/address/{walletID} | Wallet Bitcoin Addresses
*WalletDataApi* | [**v1userwalletcoindepositconfirmedWalletID**](docs/Api/WalletDataApi.md#v1userwalletcoindepositconfirmedwalletid) | **GET** /v1/user/wallet/coin/deposit/confirmed/{walletID} | Confirmed Wallet Transactions
*WalletDataApi* | [**v1userwalletcoindepositconfirmedall**](docs/Api/WalletDataApi.md#v1userwalletcoindepositconfirmedall) | **GET** /v1/user/wallet/coin/deposit/confirmed/all | Confirmed Wallet Deposit
*WalletDataApi* | [**v1userwalletcoindepositunconfirmedWalletID**](docs/Api/WalletDataApi.md#v1userwalletcoindepositunconfirmedwalletid) | **GET** /v1/user/wallet/coin/deposit/unconfirmed/{walletID} | Unconfirmed Transactions in Wallet
*WalletDataApi* | [**v1userwalletcoindepositunconfirmedall**](docs/Api/WalletDataApi.md#v1userwalletcoindepositunconfirmedall) | **GET** /v1/user/wallet/coin/deposit/unconfirmed/all | All Unconfirmed Deposits
*WalletDataApi* | [**v1userwalletcoinwallets**](docs/Api/WalletDataApi.md#v1userwalletcoinwallets) | **GET** /v1/user/wallet/coin/wallets | Wallet Details
*WalletDataApi* | [**v1walletwithdrawcancelled**](docs/Api/WalletDataApi.md#v1walletwithdrawcancelled) | **GET** /v1/wallet/coin/withdraw/cancelled | Cancelled Coin Withdrawals
*WalletDataApi* | [**v1walletwithdrawcompleted**](docs/Api/WalletDataApi.md#v1walletwithdrawcompleted) | **GET** /v1/wallet/coin/withdraw/completed | Completed Coin Withdrawals
*WalletDataApi* | [**v1walletwithdrawunverified**](docs/Api/WalletDataApi.md#v1walletwithdrawunverified) | **GET** /v1/wallet/coin/withdraw/unverified | Unverified Coin Withdrawals
*WalletDataApi* | [**v1walletwithdrawverified**](docs/Api/WalletDataApi.md#v1walletwithdrawverified) | **GET** /v1/wallet/coin/withdraw/verified | Verified Coin Withdrawals


## Documentation For Models

 - [Address](docs/Model/Address.md)
 - [AllRefData](docs/Model/AllRefData.md)
 - [AllRefDataResponse](docs/Model/AllRefDataResponse.md)
 - [AskID](docs/Model/AskID.md)
 - [BankSummaryData](docs/Model/BankSummaryData.md)
 - [BankSummaryDataResponse](docs/Model/BankSummaryDataResponse.md)
 - [BidID](docs/Model/BidID.md)
 - [ChangePassword](docs/Model/ChangePassword.md)
 - [Code](docs/Model/Code.md)
 - [CodeCountryMobile](docs/Model/CodeCountryMobile.md)
 - [CoinDepData](docs/Model/CoinDepData.md)
 - [CoinDepDataResponse](docs/Model/CoinDepDataResponse.md)
 - [ConfirmData](docs/Model/ConfirmData.md)
 - [ConfirmDataResponse](docs/Model/ConfirmDataResponse.md)
 - [DepositID](docs/Model/DepositID.md)
 - [DoubleData](docs/Model/DoubleData.md)
 - [DoubleDataResponse](docs/Model/DoubleDataResponse.md)
 - [Email](docs/Model/Email.md)
 - [FailResult](docs/Model/FailResult.md)
 - [FiatBankData](docs/Model/FiatBankData.md)
 - [FiatBankDataResponse](docs/Model/FiatBankDataResponse.md)
 - [FiatDepData](docs/Model/FiatDepData.md)
 - [FiatDepDataResponse](docs/Model/FiatDepDataResponse.md)
 - [FiatWithData](docs/Model/FiatWithData.md)
 - [FiatWithDataResponse](docs/Model/FiatWithDataResponse.md)
 - [JsValue](docs/Model/JsValue.md)
 - [KYCData](docs/Model/KYCData.md)
 - [KYCDataResponse](docs/Model/KYCDataResponse.md)
 - [LastTradeData](docs/Model/LastTradeData.md)
 - [LastTradeDataResponse](docs/Model/LastTradeDataResponse.md)
 - [LoginFormNew](docs/Model/LoginFormNew.md)
 - [LoginId](docs/Model/LoginId.md)
 - [MaxVol](docs/Model/MaxVol.md)
 - [MethodCountryMobile](docs/Model/MethodCountryMobile.md)
 - [MinFiat](docs/Model/MinFiat.md)
 - [NetkiName](docs/Model/NetkiName.md)
 - [NetkiNameAddress](docs/Model/NetkiNameAddress.md)
 - [NewAddress](docs/Model/NewAddress.md)
 - [NewBankForm](docs/Model/NewBankForm.md)
 - [NewFiatBankDeposit](docs/Model/NewFiatBankDeposit.md)
 - [NewWallet](docs/Model/NewWallet.md)
 - [NumberOtp](docs/Model/NumberOtp.md)
 - [OrderData](docs/Model/OrderData.md)
 - [OrderDataResponse](docs/Model/OrderDataResponse.md)
 - [RateData](docs/Model/RateData.md)
 - [RateDataResponse](docs/Model/RateDataResponse.md)
 - [RateDiffData](docs/Model/RateDiffData.md)
 - [RateDiffDataResponse](docs/Model/RateDiffDataResponse.md)
 - [RateVolData](docs/Model/RateVolData.md)
 - [RateVolDataResponse](docs/Model/RateVolDataResponse.md)
 - [ResetPassword](docs/Model/ResetPassword.md)
 - [SendCoin](docs/Model/SendCoin.md)
 - [SendCoinWallet](docs/Model/SendCoinWallet.md)
 - [SendExchange](docs/Model/SendExchange.md)
 - [SignupForm](docs/Model/SignupForm.md)
 - [StandardInitiateLoginResultData](docs/Model/StandardInitiateLoginResultData.md)
 - [StandardLoginResultData](docs/Model/StandardLoginResultData.md)
 - [StandardTickerResultData](docs/Model/StandardTickerResultData.md)
 - [SuccCoinRefData](docs/Model/SuccCoinRefData.md)
 - [SuccCoinRefDataResponse](docs/Model/SuccCoinRefDataResponse.md)
 - [SuccRefData](docs/Model/SuccRefData.md)
 - [SuccRefDataResponse](docs/Model/SuccRefDataResponse.md)
 - [SuccessInitiateLoginResponse](docs/Model/SuccessInitiateLoginResponse.md)
 - [SuccessLoginResponse](docs/Model/SuccessLoginResponse.md)
 - [SuccessResult](docs/Model/SuccessResult.md)
 - [SuccessResultList](docs/Model/SuccessResultList.md)
 - [SuccessTickerResponse](docs/Model/SuccessTickerResponse.md)
 - [TimeData](docs/Model/TimeData.md)
 - [TimeDataCoin](docs/Model/TimeDataCoin.md)
 - [TimeKYCData](docs/Model/TimeKYCData.md)
 - [TradeAddressData](docs/Model/TradeAddressData.md)
 - [TradeAddressDataResponse](docs/Model/TradeAddressDataResponse.md)
 - [TradeCoinWithdrawData](docs/Model/TradeCoinWithdrawData.md)
 - [TradeCoinWithdrawDataResponse](docs/Model/TradeCoinWithdrawDataResponse.md)
 - [TradeSummaryData](docs/Model/TradeSummaryData.md)
 - [TradeSummaryDataResponse](docs/Model/TradeSummaryDataResponse.md)
 - [UserSummaryData](docs/Model/UserSummaryData.md)
 - [UserSummaryDataResponse](docs/Model/UserSummaryDataResponse.md)
 - [ValidAddressSearchData](docs/Model/ValidAddressSearchData.md)
 - [ValidAddressSearchDataResponse](docs/Model/ValidAddressSearchDataResponse.md)
 - [VolData](docs/Model/VolData.md)
 - [VolDataResponse](docs/Model/VolDataResponse.md)
 - [WalletAddressData](docs/Model/WalletAddressData.md)
 - [WalletAddressDataResponse](docs/Model/WalletAddressDataResponse.md)
 - [WalletCoinWithdrawData](docs/Model/WalletCoinWithdrawData.md)
 - [WalletCoinWithdrawDataResponse](docs/Model/WalletCoinWithdrawDataResponse.md)
 - [WalletSummaryData](docs/Model/WalletSummaryData.md)
 - [WalletSummaryDataResponse](docs/Model/WalletSummaryDataResponse.md)
 - [WalletsData](docs/Model/WalletsData.md)
 - [WalletsDataResponse](docs/Model/WalletsDataResponse.md)
 - [WithdrawFiat](docs/Model/WithdrawFiat.md)
 - [WithdrawID](docs/Model/WithdrawID.md)


## Documentation For Authorization

 All endpoints do not require authorization.


## Author



