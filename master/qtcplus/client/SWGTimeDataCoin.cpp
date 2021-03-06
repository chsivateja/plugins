/**
 * Coinsecure Api Documentation
 * To generate an API key, please visit <a href='https://coinsecure.in/api' target='_new' class='homeapi'>https://coinsecure.in/api</a>.<br>Guidelines for use can be accessed at <a href='https://api.coinsecure.in/v1/guidelines'>https://api.coinsecure.in/v1/guidelines</a>.<br>Programming Language Libraries for use can be accessed at <a href='https://api.coinsecure.in/v1/code-libraries'>https://api.coinsecure.in/v1/code-libraries</a>.
 *
 * OpenAPI spec version: beta
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */


#include "SWGTimeDataCoin.h"

#include "SWGHelpers.h"

#include <QJsonDocument>
#include <QJsonArray>
#include <QObject>
#include <QDebug>

namespace Swagger {


SWGTimeDataCoin::SWGTimeDataCoin(QString* json) {
    init();
    this->fromJson(*json);
}

SWGTimeDataCoin::SWGTimeDataCoin() {
    init();
}

SWGTimeDataCoin::~SWGTimeDataCoin() {
    this->cleanup();
}

void
SWGTimeDataCoin::init() {
    time = 0L;
    verified_time = 0L;
}

void
SWGTimeDataCoin::cleanup() {
    

}

SWGTimeDataCoin*
SWGTimeDataCoin::fromJson(QString &json) {
    QByteArray array (json.toStdString().c_str());
    QJsonDocument doc = QJsonDocument::fromJson(array);
    QJsonObject jsonObject = doc.object();
    this->fromJsonObject(jsonObject);
    return this;
}

void
SWGTimeDataCoin::fromJsonObject(QJsonObject &pJson) {
    ::Swagger::setValue(&time, pJson["time"], "qint64", "");
    ::Swagger::setValue(&verified_time, pJson["verified_time"], "qint64", "");
}

QString
SWGTimeDataCoin::asJson ()
{
    QJsonObject* obj = this->asJsonObject();
    
    QJsonDocument doc(*obj);
    QByteArray bytes = doc.toJson();
    return QString(bytes);
}

QJsonObject*
SWGTimeDataCoin::asJsonObject() {
    QJsonObject* obj = new QJsonObject();
    
    obj->insert("time", QJsonValue(time));

    obj->insert("verified_time", QJsonValue(verified_time));

    return obj;
}

qint64
SWGTimeDataCoin::getTime() {
    return time;
}
void
SWGTimeDataCoin::setTime(qint64 time) {
    this->time = time;
}

qint64
SWGTimeDataCoin::getVerifiedTime() {
    return verified_time;
}
void
SWGTimeDataCoin::setVerifiedTime(qint64 verified_time) {
    this->verified_time = verified_time;
}



} /* namespace Swagger */

