/* 
 * coinMerchant Api Documentation
 *
 * To generate an API key, please visit <a href='https://pay.coinsecure.in/payment-tools/api' target='_new' class='homeapi'>https://pay.coinsecure.in/payment-tools/api</a>.<br>Guidelines for use can be accessed at <a href='https://pay.coinsecure.in/api/guidelines'>https://pay.coinsecure.in/api/guidelines</a>.
 *
 * OpenAPI spec version: 1.0B
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

package swagger

import (
	"time"
)

type SuccessMerchant struct {

	Success bool `json:"success,omitempty"`

	Message Merchant `json:"message,omitempty"`

	Time time.Time `json:"time,omitempty"`

	Method string `json:"method,omitempty"`

	Title string `json:"title,omitempty"`
}
