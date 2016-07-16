# Go API client for swagger

To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.

## Overview
This API client was generated by the [swagger-codegen](https://github.com/swagger-api/swagger-codegen) project.  By using the [swagger-spec](https://github.com/swagger-api/swagger-spec) from a remote server, you can easily generate an API client.

- API version: 1.0b
- Package version: 1.0.0
- Build date: 2016-07-16T19:10:53.298Z
- Build package: class io.swagger.codegen.languages.GoClientCodegen

## Installation
Put the package under your project folder and add the following in import:
```
    "./swagger"
```

## Documentation for API Endpoints

All URIs are relative to *https://api.coinsecure.in/*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*AccountActionsApi* | [**V1Login**](docs/AccountActionsApi.md#v1login) | **Post** /v1/login | Creates a Login Instance and returns an API Key.
*AccountActionsApi* | [**V1LoginInitiate**](docs/AccountActionsApi.md#v1logininitiate) | **Post** /v1/login/initiate | Initiate Login
*AccountActionsApi* | [**V1LoginPasswordForgot**](docs/AccountActionsApi.md#v1loginpasswordforgot) | **Post** /v1/login/password/forgot | Sends an email with a password reset token
*AccountActionsApi* | [**V1Signup**](docs/AccountActionsApi.md#v1signup) | **Post** /v1/signup | Creates a new Unverified Account.
*AccountActionsApi* | [**V1UserBankOtpNumber**](docs/AccountActionsApi.md#v1userbankotpnumber) | **Get** /v1/user/bank/otp/{number} | Send OTP for Bank Link
*AccountActionsApi* | [**V1UserExchangeKyc**](docs/AccountActionsApi.md#v1userexchangekyc) | **Put** /v1/user/exchange/kyc | Submits a New Bank Link and initial KYC Documents.
*AccountActionsApi* | [**V1UserGcmCode**](docs/AccountActionsApi.md#v1usergcmcode) | **Delete** /v1/user/gcm/{code} | Delete GCM Code
*AccountActionsApi* | [**V1UserKycOtpNumber**](docs/AccountActionsApi.md#v1userkycotpnumber) | **Get** /v1/user/kyc/otp/{number} | Send OTP for KYC Link
*AccountActionsApi* | [**V1UserLogout**](docs/AccountActionsApi.md#v1userlogout) | **Delete** /v1/user/logout | Logout User
*AccountActionsApi* | [**V1UserNetkiCreate**](docs/AccountActionsApi.md#v1usernetkicreate) | **Put** /v1/user/netki/create | Create Neki Wallet Name
*AccountActionsApi* | [**V1UserNetkiUpdate**](docs/AccountActionsApi.md#v1usernetkiupdate) | **Patch** /v1/user/netki/update | Update Netki Address
*AccountActionsApi* | [**V1UserProfileImageDelete**](docs/AccountActionsApi.md#v1userprofileimagedelete) | **Post** /v1/user/contact | Delete Profile Image
*AccountActionsApi* | [**V1UserProfileImageUpdate**](docs/AccountActionsApi.md#v1userprofileimageupdate) | **Patch** /v1/user/profile/image/update | Update Profile Image
*AccountActionsApi* | [**V1UserProfilePhone**](docs/AccountActionsApi.md#v1userprofilephone) | **Put** /v1/user/profile/phone/new | New Profile Phone
*AccountActionsApi* | [**V1UserProfilePhoneNumber**](docs/AccountActionsApi.md#v1userprofilephonenumber) | **Delete** /v1/user/profile/phone/delete | Delete Profile Phone Number
*AccountActionsApi* | [**V1UserProfilePhoneOtpNumber**](docs/AccountActionsApi.md#v1userprofilephoneotpnumber) | **Get** /v1/user/profile/phone/otp/{number} | Send OTP for Profile Phone
*AccountDataApi* | [**V1ExchangeBankSummary**](docs/AccountDataApi.md#v1exchangebanksummary) | **Get** /v1/user/exchange/bank/summary | Exchange Bank Summary
*AccountDataApi* | [**V1ExchangeUserCoinFee**](docs/AccountDataApi.md#v1exchangeusercoinfee) | **Get** /v1/user/exchange/coin/fee | Users Coin Fee Percentage
*AccountDataApi* | [**V1ExchangeUserFiatFee**](docs/AccountDataApi.md#v1exchangeuserfiatfee) | **Get** /v1/user/exchange/fiat/fee | Users Fiat Fee Percentage
*AccountDataApi* | [**V1NetkiSearchNetkiName**](docs/AccountDataApi.md#v1netkisearchnetkiname) | **Get** /v1/netki/search/{netkiName} | Coinsecure.me Netki Lookup
*AccountDataApi* | [**V1UserExchangeKycs**](docs/AccountDataApi.md#v1userexchangekycs) | **Get** /v1/user/exchange/kycs | Gets KYC Status Details
*AccountDataApi* | [**V1UserExchangeReferralCoinPaid**](docs/AccountDataApi.md#v1userexchangereferralcoinpaid) | **Get** /v1/user/exchange/referral/coin/paid | Users Paid Fiat Referrals
*AccountDataApi* | [**V1UserExchangeReferralCoinSuccessful**](docs/AccountDataApi.md#v1userexchangereferralcoinsuccessful) | **Get** /v1/user/exchange/referral/coin/successful | Gets Users Successful Referral Links
*AccountDataApi* | [**V1UserExchangeReferralFiatPaid**](docs/AccountDataApi.md#v1userexchangereferralfiatpaid) | **Get** /v1/user/exchange/referral/fiat/paid | Users Paid Fiat Referrals
*AccountDataApi* | [**V1UserExchangeReferrals**](docs/AccountDataApi.md#v1userexchangereferrals) | **Get** /v1/user/exchange/referrals | Gets Users Referral Links
*AccountDataApi* | [**V1UserExchangeTradeSummary**](docs/AccountDataApi.md#v1userexchangetradesummary) | **Get** /v1/user/exchange/trade/summary | Exchange Trade Summary
*AccountDataApi* | [**V1UserLoginTokenToken**](docs/AccountDataApi.md#v1userlogintokentoken) | **Get** /v1/user/login/token/{token} | Login Token Email
*AccountDataApi* | [**V1UserSummary**](docs/AccountDataApi.md#v1usersummary) | **Get** /v1/user/summary | Exchange Bank Summary
*AccountDataApi* | [**V1UserWalletSummary**](docs/AccountDataApi.md#v1userwalletsummary) | **Get** /v1/user/wallet/summary | Exchange Bank Summary
*BlockchainToolsApi* | [**V1BitcoinSearchAddress**](docs/BlockchainToolsApi.md#v1bitcoinsearchaddress) | **Get** /v1/bitcoin/search/{any} | Search Bitcoin Blockchain
*BlockchainToolsApi* | [**V1BitcoinSearchTxid**](docs/BlockchainToolsApi.md#v1bitcoinsearchtxid) | **Get** /v1/bitcoin/search/confirmation/{txid} | Get Confirmations
*ExchangeBankActionsApi* | [**V1UserExchangeBankCoinWithdrawInitiate**](docs/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawinitiate) | **Post** /v1/user/exchange/bank/coin/withdraw/initiate | Initiate Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**V1UserExchangeBankCoinWithdrawNewVerifycode**](docs/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawnewverifycode) | **Post** /v1/user/exchange/bank/coin/withdraw/newVerifycode | Gets a Verification Code.
*ExchangeBankActionsApi* | [**V1UserExchangeBankCoinWithdrawUnverifiedCancel**](docs/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawunverifiedcancel) | **Delete** /v1/user/exchange/bank/coin/withdraw/unverified/cancel | Cancel Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**V1UserExchangeBankCoinWithdrawVerify**](docs/ExchangeBankActionsApi.md#v1userexchangebankcoinwithdrawverify) | **Put** /v1/user/exchange/bank/coin/withdraw/verify | Verify Bitcoin Withdrawal
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatAccountNew**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiataccountnew) | **Put** /v1/user/exchange/bank/fiat/account/new | New Bank Link
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatDepositCancel**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatdepositcancel) | **Delete** /v1/user/exchange/bank/fiat/deposit/cancel | Cancel Unverified Exchange Fiat Deposit
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatDepositNew**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatdepositnew) | **Put** /v1/user/exchange/bank/fiat/deposit/new | New Exchange Fiat Deposit
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatWithdrawInitiate**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawinitiate) | **Post** /v1/user/exchange/bank/fiat/withdraw/initiate | Initiate Fiat Withdrawal
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatWithdrawNewVerifycode**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawnewverifycode) | **Post** /v1/user/exchange/bank/fiat/withdraw/newVerifycode | Gets a Fiat Verification Code.
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatWithdrawUnverifiedCancel**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawunverifiedcancel) | **Delete** /v1/user/exchange/bank/fiat/withdraw/unverified/cancel | Cancel Fiat Withdrawal
*ExchangeBankActionsApi* | [**V1UserExchangeBankFiatWithdrawVerify**](docs/ExchangeBankActionsApi.md#v1userexchangebankfiatwithdrawverify) | **Put** /v1/user/exchange/bank/fiat/withdraw/verify | Verify Fiat Withdrawal
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinAddresses**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinaddresses) | **Get** /v1/user/exchange/bank/coin/addresses | Exchange Coin Addresses
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinBalanceAvailable**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalanceavailable) | **Get** /v1/user/exchange/bank/coin/balance/total | Available Exchange Coin Balance
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinBalancePending**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalancepending) | **Get** /v1/user/exchange/bank/coin/balance/pending | In Trade Coin Balance
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinBalanceTotal**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinbalancetotal) | **Get** /v1/user/exchange/bank/coin/balance/available | Total Exchange Coin Balance
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinDepositCancelled**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositcancelled) | **Get** /v1/user/exchange/bank/coin/deposit/cancelled | Cancelled Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinDepositUnverified**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositunverified) | **Get** /v1/user/exchange/bank/coin/deposit/unverified | Unverified Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinDepositVerified**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoindepositverified) | **Get** /v1/user/exchange/bank/coin/deposit/verified | Verified Exchange Coin Deposits
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinWithdrawCancelled**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawcancelled) | **Get** /v1/user/exchange/bank/coin/withdraw/cancelled | Cancelled Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinWithdrawCompleted**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawcompleted) | **Get** /v1/user/exchange/bank/coin/withdraw/completed | Completed Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinWithdrawUnverified**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawunverified) | **Get** /v1/user/exchange/bank/coin/withdraw/unverified | Unverified Exchange Coin Withdrawals
*ExchangeBankCoinDataApi* | [**V1UserExchangeBankCoinWithdrawVerified**](docs/ExchangeBankCoinDataApi.md#v1userexchangebankcoinwithdrawverified) | **Get** /v1/user/exchange/bank/coin/withdraw/verified | Verified Exchange Coin Withdrawals
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatAccounts**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiataccounts) | **Get** /v1/user/exchange/bank/fiat/accounts | Exchange Bitcoin Deposit Addresses
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatBalanceAvailable**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalanceavailable) | **Get** /v1/user/exchange/bank/fiat/balance/total | Available Exchange Fiat Balance
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatBalancePending**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalancepending) | **Get** /v1/user/exchange/bank/fiat/balance/pending | In Trade Coin Balance
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatBalanceTotal**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatbalancetotal) | **Get** /v1/user/exchange/bank/fiat/balance/available | Total Exchange Fiat Balance
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatDepositCancelled**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositcancelled) | **Get** /v1/user/exchange/bank/fiat/deposit/cancelled | Cancelled Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatDepositUnverified**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositunverified) | **Get** /v1/user/exchange/bank/fiat/deposit/unverified | Unverified Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatDepositVerified**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatdepositverified) | **Get** /v1/user/exchange/bank/fiat/deposit/verified | Verified Exchange Fiat Deposits
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatWithdrawCancelled**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawcancelled) | **Get** /v1/user/exchange/bank/fiat/withdraw/cancelled | Cancelled Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatWithdrawCompleted**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawcompleted) | **Get** /v1/user/exchange/bank/fiat/withdraw/completed | Completed Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatWithdrawUnverified**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawunverified) | **Get** /v1/user/exchange/bank/fiat/withdraw/unverified | Unverified Exchange Fiat Withdrawals
*ExchangeBankFiatDataApi* | [**V1UserExchangeBankFiatWithdrawVerified**](docs/ExchangeBankFiatDataApi.md#v1userexchangebankfiatwithdrawverified) | **Get** /v1/user/exchange/bank/fiat/withdraw/verified | Verified Exchange Fiat Withdrawals
*ExchangeTradeActionsApi* | [**V1UserExchangeAskCancel**](docs/ExchangeTradeActionsApi.md#v1userexchangeaskcancel) | **Delete** /v1/user/exchange/ask/cancel | Cancel Open Sell Order
*ExchangeTradeActionsApi* | [**V1UserExchangeAskNew**](docs/ExchangeTradeActionsApi.md#v1userexchangeasknew) | **Put** /v1/user/exchange/ask/new | BTC Sell Order
*ExchangeTradeActionsApi* | [**V1UserExchangeBidCancel**](docs/ExchangeTradeActionsApi.md#v1userexchangebidcancel) | **Delete** /v1/user/exchange/bid/cancel | Cancel Open Buy Order
*ExchangeTradeActionsApi* | [**V1UserExchangeBidNew**](docs/ExchangeTradeActionsApi.md#v1userexchangebidnew) | **Put** /v1/user/exchange/bid/new | BTC Buy Order
*ExchangeTradeActionsApi* | [**V1UserExchangeInstantBuy**](docs/ExchangeTradeActionsApi.md#v1userexchangeinstantbuy) | **Put** /v1/user/exchange/instant/buy | Instantly Buy BTC
*ExchangeTradeActionsApi* | [**V1UserExchangeInstantSell**](docs/ExchangeTradeActionsApi.md#v1userexchangeinstantsell) | **Put** /v1/user/exchange/instant/sell | Instantly Sell BTC
*ExchangeTradeDataApi* | [**V1ExchangeAskLow**](docs/ExchangeTradeDataApi.md#v1exchangeasklow) | **Get** /v1/exchange/ask/low | Lowest Ask
*ExchangeTradeDataApi* | [**V1ExchangeAskOrders**](docs/ExchangeTradeDataApi.md#v1exchangeaskorders) | **Get** /v1/exchange/ask/orders | All Sell Orders
*ExchangeTradeDataApi* | [**V1ExchangeBidHigh**](docs/ExchangeTradeDataApi.md#v1exchangebidhigh) | **Get** /v1/exchange/bid/high | Returns the Highest Bid in the Order Book
*ExchangeTradeDataApi* | [**V1ExchangeBidOrders**](docs/ExchangeTradeDataApi.md#v1exchangebidorders) | **Get** /v1/exchange/bid/orders | All Buy Orders
*ExchangeTradeDataApi* | [**V1ExchangeLastTrade**](docs/ExchangeTradeDataApi.md#v1exchangelasttrade) | **Get** /v1/exchange/lastTrade | Last Trade
*ExchangeTradeDataApi* | [**V1ExchangeMax24Hr**](docs/ExchangeTradeDataApi.md#v1exchangemax24hr) | **Get** /v1/exchange/max24Hr | Max 24 Hour Rate
*ExchangeTradeDataApi* | [**V1ExchangeMin24Hr**](docs/ExchangeTradeDataApi.md#v1exchangemin24hr) | **Get** /v1/exchange/min24Hr | Min 24 Hour Rate
*ExchangeTradeDataApi* | [**V1ExchangeTicker**](docs/ExchangeTradeDataApi.md#v1exchangeticker) | **Get** /v1/exchange/ticker | Exchange Ticker
*ExchangeTradeDataApi* | [**V1UserExchangeAskCancelled**](docs/ExchangeTradeDataApi.md#v1userexchangeaskcancelled) | **Get** /v1/user/exchange/ask/cancelled | Cancelled User Sell Orders
*ExchangeTradeDataApi* | [**V1UserExchangeAskCompleted**](docs/ExchangeTradeDataApi.md#v1userexchangeaskcompleted) | **Get** /v1/user/exchange/ask/completed | Completed User Sell Orders
*ExchangeTradeDataApi* | [**V1UserExchangeAskPending**](docs/ExchangeTradeDataApi.md#v1userexchangeaskpending) | **Get** /v1/user/exchange/ask/pending | Pending User Sell Orders
*ExchangeTradeDataApi* | [**V1UserExchangeBidCancelled**](docs/ExchangeTradeDataApi.md#v1userexchangebidcancelled) | **Get** /v1/user/exchange/bid/cancelled | Cancelled User Buy Orders
*ExchangeTradeDataApi* | [**V1UserExchangeBidCompleted**](docs/ExchangeTradeDataApi.md#v1userexchangebidcompleted) | **Get** /v1/user/exchange/bid/completed | Completed User Buy Orders
*ExchangeTradeDataApi* | [**V1UserExchangeBidPending**](docs/ExchangeTradeDataApi.md#v1userexchangebidpending) | **Get** /v1/user/exchange/bid/pending | Pending User Buy Orders
*SecurityActionsApi* | [**V1MfaAuthyInitiate**](docs/SecurityActionsApi.md#v1mfaauthyinitiate) | **Post** /v1/mfa/authy/initiate | Initiate Authy Registration.
*SecurityActionsApi* | [**V1MfaGaInitiate**](docs/SecurityActionsApi.md#v1mfagainitiate) | **Post** /v1/mfa/ga/initiate | Initiate GA Registration.
*SecurityActionsApi* | [**V1UserMfaAuthyCall**](docs/SecurityActionsApi.md#v1usermfaauthycall) | **Get** /v1/mfa/authy/call | Authy Call Code
*SecurityActionsApi* | [**V1UserMfaAuthyDisable**](docs/SecurityActionsApi.md#v1usermfaauthydisable) | **Delete** /v1/user/mfa/authy/disable | Disable Authy
*SecurityActionsApi* | [**V1UserMfaAuthyInitiateEnable**](docs/SecurityActionsApi.md#v1usermfaauthyinitiateenable) | **Put** /v1/user/mfa/authy/initiate/enable | Verify Authy Registration
*SecurityActionsApi* | [**V1UserMfaAuthySms**](docs/SecurityActionsApi.md#v1usermfaauthysms) | **Get** /v1/mfa/authy/sms | Authy Sms Code
*SecurityActionsApi* | [**V1UserMfaGaDisable**](docs/SecurityActionsApi.md#v1usermfagadisable) | **Delete** /v1/user/mfa/ga/disable | Disable Google Authenticator
*SecurityActionsApi* | [**V1UserMfaGaInitiateEnable**](docs/SecurityActionsApi.md#v1usermfagainitiateenable) | **Put** /v1/user/mfa/ga/initiate/enable | Enable Google Authenticator
*SecurityActionsApi* | [**V1UserPasswordChange**](docs/SecurityActionsApi.md#v1userpasswordchange) | **Patch** /v1/user/password/change | Change Password.
*SecurityActionsApi* | [**V1UserPasswordReset**](docs/SecurityActionsApi.md#v1userpasswordreset) | **Patch** /v1/user/password/reset | Reset Password.
*WalletActionsApi* | [**V1UserWalletCoinAddressNew**](docs/WalletActionsApi.md#v1userwalletcoinaddressnew) | **Put** /v1/user/wallet/coin/address/new | New Bitcoin Address
*WalletActionsApi* | [**V1UserWalletCoinNew**](docs/WalletActionsApi.md#v1userwalletcoinnew) | **Put** /v1/user/wallet/coin/new | Create New Wallet
*WalletActionsApi* | [**V1UserWalletCoinWithdrawInitiate**](docs/WalletActionsApi.md#v1userwalletcoinwithdrawinitiate) | **Post** /v1/user/wallet/coin/withdraw/initiate | Initiate Bitcoin Withdrawal
*WalletActionsApi* | [**V1UserWalletCoinWithdrawSendToExchange**](docs/WalletActionsApi.md#v1userwalletcoinwithdrawsendtoexchange) | **Put** /v1/user/wallet/coin/withdraw/sendToExchange | Send to Exchange
*WalletActionsApi* | [**V1UserWalletCoinWithdrawUnverifiedCancel**](docs/WalletActionsApi.md#v1userwalletcoinwithdrawunverifiedcancel) | **Delete** /v1/user/wallet/coin/withdraw/unverified/cancel | Cancel Bitcoin Withdrawal
*WalletActionsApi* | [**V1UserWalletCoinWithdrawVerify**](docs/WalletActionsApi.md#v1userwalletcoinwithdrawverify) | **Put** /v1/user/wallet/coin/withdraw/verify | Verify Bitcoin Withdrawal
*WalletActionsApi* | [**V1WalletCoinWithdrawNewVerifycode**](docs/WalletActionsApi.md#v1walletcoinwithdrawnewverifycode) | **Post** /v1/wallet/coin/withdraw/newVerifycode | Gets a Verification Code
*WalletDataApi* | [**V1UserWalletCoinAddressWalletID**](docs/WalletDataApi.md#v1userwalletcoinaddresswalletid) | **Get** /v1/user/wallet/coin/address/{walletID} | Wallet Bitcoin Addresses
*WalletDataApi* | [**V1UserWalletCoinDepositConfirmedAll**](docs/WalletDataApi.md#v1userwalletcoindepositconfirmedall) | **Get** /v1/user/wallet/coin/deposit/confirmed/all | Confirmed Wallet Deposit
*WalletDataApi* | [**V1UserWalletCoinDepositConfirmedWalletID**](docs/WalletDataApi.md#v1userwalletcoindepositconfirmedwalletid) | **Get** /v1/user/wallet/coin/deposit/confirmed/{walletID} | Confirmed Wallet Transactions
*WalletDataApi* | [**V1UserWalletCoinDepositUnconfirmedAll**](docs/WalletDataApi.md#v1userwalletcoindepositunconfirmedall) | **Get** /v1/user/wallet/coin/deposit/unconfirmed/all | All Unconfirmed Deposits
*WalletDataApi* | [**V1UserWalletCoinDepositUnconfirmedWalletID**](docs/WalletDataApi.md#v1userwalletcoindepositunconfirmedwalletid) | **Get** /v1/user/wallet/coin/deposit/unconfirmed/{walletID} | Unconfirmed Transactions in Wallet
*WalletDataApi* | [**V1UserWalletCoinWallets**](docs/WalletDataApi.md#v1userwalletcoinwallets) | **Get** /v1/user/wallet/coin/wallets | Wallet Details
*WalletDataApi* | [**V1WalletWithdrawCancelled**](docs/WalletDataApi.md#v1walletwithdrawcancelled) | **Get** /v1/wallet/coin/withdraw/cancelled | Cancelled Coin Withdrawals
*WalletDataApi* | [**V1WalletWithdrawCompleted**](docs/WalletDataApi.md#v1walletwithdrawcompleted) | **Get** /v1/wallet/coin/withdraw/completed | Completed Coin Withdrawals
*WalletDataApi* | [**V1WalletWithdrawUnverified**](docs/WalletDataApi.md#v1walletwithdrawunverified) | **Get** /v1/wallet/coin/withdraw/unverified | Unverified Coin Withdrawals
*WalletDataApi* | [**V1WalletWithdrawVerified**](docs/WalletDataApi.md#v1walletwithdrawverified) | **Get** /v1/wallet/coin/withdraw/verified | Verified Coin Withdrawals


## Documentation For Models

 - [Address](docs/Address.md)
 - [AllRefData](docs/AllRefData.md)
 - [AllRefDataResponse](docs/AllRefDataResponse.md)
 - [AskId](docs/AskId.md)
 - [BankSummaryData](docs/BankSummaryData.md)
 - [BankSummaryDataResponse](docs/BankSummaryDataResponse.md)
 - [BidId](docs/BidId.md)
 - [ChangePassword](docs/ChangePassword.md)
 - [Code](docs/Code.md)
 - [CodeCountryMobile](docs/CodeCountryMobile.md)
 - [CoinDepData](docs/CoinDepData.md)
 - [CoinDepDataResponse](docs/CoinDepDataResponse.md)
 - [ConfirmData](docs/ConfirmData.md)
 - [ConfirmDataResponse](docs/ConfirmDataResponse.md)
 - [DepositId](docs/DepositId.md)
 - [DoubleData](docs/DoubleData.md)
 - [DoubleDataResponse](docs/DoubleDataResponse.md)
 - [Email](docs/Email.md)
 - [FailResult](docs/FailResult.md)
 - [FiatBankData](docs/FiatBankData.md)
 - [FiatBankDataResponse](docs/FiatBankDataResponse.md)
 - [FiatDepData](docs/FiatDepData.md)
 - [FiatDepDataResponse](docs/FiatDepDataResponse.md)
 - [FiatWithData](docs/FiatWithData.md)
 - [FiatWithDataResponse](docs/FiatWithDataResponse.md)
 - [JsValue](docs/JsValue.md)
 - [KycData](docs/KycData.md)
 - [KycDataResponse](docs/KycDataResponse.md)
 - [LastTradeData](docs/LastTradeData.md)
 - [LastTradeDataResponse](docs/LastTradeDataResponse.md)
 - [LoginFormNew](docs/LoginFormNew.md)
 - [LoginId](docs/LoginId.md)
 - [MaxVol](docs/MaxVol.md)
 - [MethodCountryMobile](docs/MethodCountryMobile.md)
 - [MinFiat](docs/MinFiat.md)
 - [NetkiName](docs/NetkiName.md)
 - [NetkiNameAddress](docs/NetkiNameAddress.md)
 - [NewAddress](docs/NewAddress.md)
 - [NewBankForm](docs/NewBankForm.md)
 - [NewFiatBankDeposit](docs/NewFiatBankDeposit.md)
 - [NewWallet](docs/NewWallet.md)
 - [NumberOtp](docs/NumberOtp.md)
 - [OrderData](docs/OrderData.md)
 - [OrderDataResponse](docs/OrderDataResponse.md)
 - [RateData](docs/RateData.md)
 - [RateDataResponse](docs/RateDataResponse.md)
 - [RateDiffData](docs/RateDiffData.md)
 - [RateDiffDataResponse](docs/RateDiffDataResponse.md)
 - [RateVolData](docs/RateVolData.md)
 - [RateVolDataResponse](docs/RateVolDataResponse.md)
 - [ResetPassword](docs/ResetPassword.md)
 - [SendCoin](docs/SendCoin.md)
 - [SendCoinWallet](docs/SendCoinWallet.md)
 - [SendExchange](docs/SendExchange.md)
 - [SignupForm](docs/SignupForm.md)
 - [StandardInitiateLoginResultData](docs/StandardInitiateLoginResultData.md)
 - [StandardLoginResultData](docs/StandardLoginResultData.md)
 - [StandardTickerResultData](docs/StandardTickerResultData.md)
 - [SuccCoinRefData](docs/SuccCoinRefData.md)
 - [SuccCoinRefDataResponse](docs/SuccCoinRefDataResponse.md)
 - [SuccRefData](docs/SuccRefData.md)
 - [SuccRefDataResponse](docs/SuccRefDataResponse.md)
 - [SuccessInitiateLoginResponse](docs/SuccessInitiateLoginResponse.md)
 - [SuccessLoginResponse](docs/SuccessLoginResponse.md)
 - [SuccessResult](docs/SuccessResult.md)
 - [SuccessResultList](docs/SuccessResultList.md)
 - [SuccessTickerResponse](docs/SuccessTickerResponse.md)
 - [TimeData](docs/TimeData.md)
 - [TimeDataCoin](docs/TimeDataCoin.md)
 - [TimeKycData](docs/TimeKycData.md)
 - [TradeAddressData](docs/TradeAddressData.md)
 - [TradeAddressDataResponse](docs/TradeAddressDataResponse.md)
 - [TradeCoinWithdrawData](docs/TradeCoinWithdrawData.md)
 - [TradeCoinWithdrawDataResponse](docs/TradeCoinWithdrawDataResponse.md)
 - [TradeSummaryData](docs/TradeSummaryData.md)
 - [TradeSummaryDataResponse](docs/TradeSummaryDataResponse.md)
 - [UserSummaryData](docs/UserSummaryData.md)
 - [UserSummaryDataResponse](docs/UserSummaryDataResponse.md)
 - [ValidAddressSearchData](docs/ValidAddressSearchData.md)
 - [ValidAddressSearchDataResponse](docs/ValidAddressSearchDataResponse.md)
 - [VolData](docs/VolData.md)
 - [VolDataResponse](docs/VolDataResponse.md)
 - [WalletAddressData](docs/WalletAddressData.md)
 - [WalletAddressDataResponse](docs/WalletAddressDataResponse.md)
 - [WalletCoinWithdrawData](docs/WalletCoinWithdrawData.md)
 - [WalletCoinWithdrawDataResponse](docs/WalletCoinWithdrawDataResponse.md)
 - [WalletSummaryData](docs/WalletSummaryData.md)
 - [WalletSummaryDataResponse](docs/WalletSummaryDataResponse.md)
 - [WalletsData](docs/WalletsData.md)
 - [WalletsDataResponse](docs/WalletsDataResponse.md)
 - [WithdrawFiat](docs/WithdrawFiat.md)
 - [WithdrawId](docs/WithdrawId.md)


## Documentation For Authorization

 All endpoints do not require authorization.


## Author


