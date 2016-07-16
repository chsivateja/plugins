/* 
 * Coinsecure Api Documentation
 *
 * To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.
 *
 * OpenAPI spec version: 1.0b
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using NUnit.Framework;

using IO.Swagger.Client;
using IO.Swagger.Api;
using IO.Swagger.Model;

namespace IO.Swagger.Test
{
    /// <summary>
    ///  Class for testing ExchangeBankActionsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    [TestFixture]
    public class ExchangeBankActionsApiTests
    {
        private ExchangeBankActionsApi instance;

        /// <summary>
        /// Setup before each unit test
        /// </summary>
        [SetUp]
        public void Init()
        {
            instance = new ExchangeBankActionsApi();
        }

        /// <summary>
        /// Clean up after each unit test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of ExchangeBankActionsApi
        /// </summary>
        [Test]
        public void InstanceTest()
        {
            Assert.IsInstanceOf<ExchangeBankActionsApi> (instance, "instance is a ExchangeBankActionsApi");
        }

        
        /// <summary>
        /// Test V1userexchangebankcoinwithdrawinitiate
        /// </summary>
        [Test]
        public void V1userexchangebankcoinwithdrawinitiateTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankcoinwithdrawinitiate'
            SendCoin body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankcoinwithdrawinitiate(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankcoinwithdrawnewVerifycode
        /// </summary>
        [Test]
        public void V1userexchangebankcoinwithdrawnewVerifycodeTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankcoinwithdrawnewVerifycode'
            WithdrawID body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankcoinwithdrawnewVerifycode(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankcoinwithdrawunverifiedcancel
        /// </summary>
        [Test]
        public void V1userexchangebankcoinwithdrawunverifiedcancelTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankcoinwithdrawunverifiedcancel'
            WithdrawID body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankcoinwithdrawunverifiedcancel(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankcoinwithdrawverify
        /// </summary>
        [Test]
        public void V1userexchangebankcoinwithdrawverifyTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankcoinwithdrawverify'
            Code body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankcoinwithdrawverify(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiataccountnew
        /// </summary>
        [Test]
        public void V1userexchangebankfiataccountnewTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiataccountnew'
            NewBankForm body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiataccountnew(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatdepositcancel
        /// </summary>
        [Test]
        public void V1userexchangebankfiatdepositcancelTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatdepositcancel'
            DepositID body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatdepositcancel(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatdepositnew
        /// </summary>
        [Test]
        public void V1userexchangebankfiatdepositnewTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatdepositnew'
            NewFiatBankDeposit body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatdepositnew(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatwithdrawinitiate
        /// </summary>
        [Test]
        public void V1userexchangebankfiatwithdrawinitiateTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatwithdrawinitiate'
            WithdrawFiat body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatwithdrawinitiate(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatwithdrawnewVerifycode
        /// </summary>
        [Test]
        public void V1userexchangebankfiatwithdrawnewVerifycodeTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatwithdrawnewVerifycode'
            WithdrawID body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatwithdrawnewVerifycode(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatwithdrawunverifiedcancel
        /// </summary>
        [Test]
        public void V1userexchangebankfiatwithdrawunverifiedcancelTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatwithdrawunverifiedcancel'
            WithdrawID body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatwithdrawunverifiedcancel(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
        /// <summary>
        /// Test V1userexchangebankfiatwithdrawverify
        /// </summary>
        [Test]
        public void V1userexchangebankfiatwithdrawverifyTest()
        {
            // TODO: add unit test for the method 'V1userexchangebankfiatwithdrawverify'
            Code body = null; // TODO: replace null with proper value
            string authorization = null; // TODO: replace null with proper value
            string accept = null; // TODO: replace null with proper value
            var response = instance.V1userexchangebankfiatwithdrawverify(body, authorization, accept);
            Assert.IsInstanceOf<SuccessResult> (response, "response is SuccessResult");
        }
        
    }

}