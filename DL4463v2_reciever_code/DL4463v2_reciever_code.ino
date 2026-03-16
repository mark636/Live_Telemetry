#define RXD2 16
#define TXD2 17
unsigned long timeout=0;

void setup() {
  Serial.begin(115200);
  Serial2.begin(115200, SERIAL_8N1, 16, 17);
  pinMode(21, OUTPUT);
  pinMode(23, OUTPUT);
  digitalWrite(21, LOW);
  digitalWrite(23,LOW);
 }

void loop() {
  while (Serial2.available()) {
    Serial.print(char(Serial2.read()));
  }
}
