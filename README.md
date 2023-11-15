# RESTfull_API
קופת חולים
תיאור הפרויקט:
מערכת לניהול תורים לקופת חולים  באמצעות המערכת ניתן להזמין תור לרופא 
ולנהל את כלל התורים בתחנה.
ישויות:
פציינט
רופא
תור
מיפוי Routs לפציינט:
שליפת רשימת פציינטים	GET:https//machabi.co.il/patients
שליפת פציינט לפי מזהה	GET:https//machabi.co.il/patients/1
הוספת פציינט	POST: https//machabi.co.il/patients
עדכון פציינט	PUT: https//machabi.co.il/patients/1
עדכון סטטוס	PUT:https//machabi.co.il/patients/1/status

מיפוי Routs לרופאים:
שליפת רשימת רופאים	GET:https//machabi.co.il/doctors
שליפת רופא לפי מזהה	GET:https//machabi.co.il/doctors/1
הוספת רופא	POST: https//machabi.co.il/doctors
עדכון רופא	PUT: https//machabi.co.il/doctors/1
עדכון סטטוס	PUT:https//machabi.co.il/doctors/1/status
	
מיפוי Routs לתורים:	
שליפת רשימת תורים	GET:https//machabi.co.il/doctors
שליפת תור לפי מזהה	GET:https//machabi.co.il/doctors/1
הוספת תור	POST: https//machabi.co.il/doctors
עדכון תור	PUT: https//machabi.co.il/doctors/1
מחיקת תור	DELETE: https//machabi.co.il/doctors/1

