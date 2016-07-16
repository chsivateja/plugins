# coding: utf-8

"""
    coinMerchant Api Documentation

    To generate an API key, please visit <a href='https://pay.coinsecure.in/payment-tools/api' target='_new' class='homeapi'>https://pay.coinsecure.in/payment-tools/api</a>.<br>Guidelines for use can be accessed at <a href='https://pay.coinsecure.in/api/guidelines'>https://pay.coinsecure.in/api/guidelines</a>.

    OpenAPI spec version: 1.0B
    
    Generated by: https://github.com/swagger-api/swagger-codegen.git
    
    Licensed under the Apache License, Version 2.0 (the "License");
    you may not use this file except in compliance with the License.
    You may obtain a copy of the License at
    
        http://www.apache.org/licenses/LICENSE-2.0
    
    Unless required by applicable law or agreed to in writing, software
    distributed under the License is distributed on an "AS IS" BASIS,
    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
    See the License for the specific language governing permissions and
    limitations under the License.
"""

from __future__ import absolute_import

import os
import sys
import unittest

import swagger_client
from swagger_client.rest import ApiException
from swagger_client.apis.invoice_data_api import InvoiceDataApi


class TestInvoiceDataApi(unittest.TestCase):
    """ InvoiceDataApi unit test stubs """

    def setUp(self):
        self.api = swagger_client.apis.invoice_data_api.InvoiceDataApi()

    def tearDown(self):
        pass

    def test_get_canc_invoices(self):
        """
        Test case for get_canc_invoices

        GET ALL CANCELLED INVOICES
        """
        pass

    def test_get_complete_invoices(self):
        """
        Test case for get_complete_invoices

        GET ALL COMPLETED INVOICES
        """
        pass

    def test_get_conf_invoices(self):
        """
        Test case for get_conf_invoices

        GET ALL CONFIRMED INVOICES
        """
        pass

    def test_get_invoice_from_id(self):
        """
        Test case for get_invoice_from_id

        GET INVOICE FROM ID
        """
        pass

    def test_get_paid_invoices(self):
        """
        Test case for get_paid_invoices

        GET ALL PAID INVOICES
        """
        pass

    def test_get_refund_invoices(self):
        """
        Test case for get_refund_invoices

        GET ALL REFUND INVOICES
        """
        pass

    def test_get_unprocessed_invoices(self):
        """
        Test case for get_unprocessed_invoices

        GET ALL UNPROCESSED INVOICES
        """
        pass


if __name__ == '__main__':
    unittest.main()