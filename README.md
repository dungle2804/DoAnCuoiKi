## Đồ án cuối kì Adv OOP C#
# CHƯƠNG TRÌNH SOẠN ĐỀ VÀ THI TRẮC NGHIỆM

**1. Student information**
* 2059042 - Nguyễn Hoàng Trường Thịnh - 20BIT1
  <p>Email:2059042@itec.hcmus.edu.vn</p>
* 2059006 - Lê Anh Dũng - 20BIT1
  <p>Email:2059006@itec.hcmus.edu.vn</p>

***
**2. Github information**
* URL: https://github.com/dungle2804/DoAnCuoiKi-2059006-2059042

***
**3. Function of Project**

1. Thitracnghiem form
<p>- Có mục điền thông tin đăng nhập của thí sinh, giúp cho việc kiểm soát số lượng thí sinh cũng như chấm bài dễ dàng hơn, nếu không đăng nhập thì sẽ không làm bài được.</p>

<p>- Có thể load được đề lên thông qua 1 textbox giúp thân thiện và dễ nhìn với thí sinh hơn</p>

<p>- Có 4 radio button được dùng để làm 4 đáp án trắc nghiệm cho câu hỏi, các đáp án cũng được thực hiện như tương tự như câu hỏi, thông qua việc sử dụng radion button giúp việc lựa chọn của đối tượng dễ dàng hơn và giúp lưu câu trả lời.</p>

<p>- Form có nút bắt đầu làm bài để giúp thí sinh bắt đầu đề thi và cũng như đồng hồ bắt đầu hiện lên và đếm ngược. Trước khi bấm bắt đầu thì tất cả các nút đề bị vô hiệu hóa, đề cũng không được load lên nhằm tránh tình trạng gian lận</p>

<p>- Trong form còn được tạo thêm các nút bao gồm tiếp theo và trước đó nhằm giúp thí sinh có thể bấm qua câu tiếp theo hoặc lùi câu trước đó, giúp thí sinh có thể sửa đổi đáp án nếu có ý định.</p>

<p>- Cũng như có luôn 1 cái nút hoàn thành để thí sinh có thể nộp bài nếu đã hoàn thành xong, khi bấm nút hoàn thành thì form sẽ tự đông tắt đồng thời lưu xuống 1 file xml bài làm của thí sinh, giúp tránh hiện tượng gian lận.</p>

<p>- Có thêm 1 đồng hồ đếm ngược thời gian mà chỉ có giám thị mới có thể set được giờ, khi đồng hồ đếm ngược thì ngay lập tức form thi sẽ tự động tắt nhầm tránh trường hợp thí sinh làm bài quá giờ qui định, tất cả câu trả lời của thí sinh cũng sẽ được ghi lại.</p>

![image](https://user-images.githubusercontent.com/91233366/145155508-81efe0db-258d-45c0-b3d2-2ecf5d5d5712.png)

![image](https://user-images.githubusercontent.com/91233366/145155555-a6f618cb-16d1-4d99-84c3-fa95346b0a87.png)

![image](https://user-images.githubusercontent.com/91233366/145155572-1e55f894-729b-4dce-961e-a6a17867f802.png)


2. File XML của Thitracnghiem form
<p>- Có 1 file XML được đặt tên là test chứa đề để dành cho việc kiểm tra, và sẽ không có bất kìa dòng nào chỉ đáp án nhằm tránh gian lận</p>

![image](https://user-images.githubusercontent.com/91233366/145155608-db9ed976-c49a-4cf9-bb65-28cd0183e53b.png)

3. Soandethi-Chamtracnghiem Form
<p>- Ở phần soạn đề, giám thị có thể tự tạo ra 1 đề theo mong muốn bằng cách tự chọn các câu có trong ngân hàng đề được chứ trong file DeThi.xml.</p>

<p>- Đồng thời giám thị cũngg có thể tự tạo 1 đề thi với các câu hỏi ngẫu nhiên chỉ bằng cách cho số lượng câu hỏi mong muốn vào 1 textbox và bấm tạo đề, hệ thống sẽ tự động chọn bất kì câu hỏi tự ngân hàng đề cho tới khi đủ số lượng thì sẽ xuất ra 1 fie xml đề mới.</p>

<p>Form tạo đề</p>
![image](https://user-images.githubusercontent.com/91233366/145155653-b9649c1b-a44d-4423-a918-f37d332af29d.png)

<p>Tạo đề ngẫu nhiên bằng cách cho số lượng câu hỏi.</p>
![image](https://user-images.githubusercontent.com/91233366/145155720-38971ebd-c3f7-4896-9d09-e817ad866b27.png)

<p>- Phần chấm bài</p>
![image](https://user-images.githubusercontent.com/91233366/145155745-4759794f-a12c-4e7c-a79e-102626294122.png)

<p>- Phần tự tạo 1 đề thi mới</p>
![image](https://user-images.githubusercontent.com/91233366/145155844-511d7603-0175-40d8-b3e8-cdf9fa4fec66.png)

4. Các file XML có trong Soandethi-Chamtracnghiem Form
<p>Bao gồm file XML tên DeThi chứa ngân hàng đề, khi tạo ra đề sẽ được lưu vào file Test.xml ở phía trên nhằm cho mục đích load đề thi, và 1 file XML bài làm của thí sinh nhằm mục đích chấm bài</p>

<p>ngân hàng đề</p>
![image](https://user-images.githubusercontent.com/91233366/145155926-d06c0ddc-bae4-4005-a749-b19e66881f9f.png)

<p>File bài làm của thí sinh</p>
![image](https://user-images.githubusercontent.com/91233366/145155958-9c25c11d-b19f-4118-aeaf-9bdc73be897d.png)

***
**Tự đánh giá chương trình** 
* Điểm mạnh 
<p>- Giao diện trực quan dễ nhìn, dễ sử dụng, thân thiện với người dùng</p>
<p>-   </p>


* Điểm yếu
<p>- Chưa hoàn thành chức năng chấm bài của chương trình</p>
<p>- Khi tạo đề ngẫu nhiên nếu bấm quá 2 chương trình sẽ bị crash</p>
<p>- Nút next trong form thi trắc nghiệm mỗi lần sử dụng sẽ bị reset toàn bộ radio button đáp án, tuy nhiên dữ liệu vẫn được lưu, gây khó khăn trong việc xác định đáp án đã chọn cho người dùng</p>


***
**Các nguồn tham khảo**
<p>- Có sự hướng dẫn và giúp đỡ của thầy Nguyễn Đức Huy: https://github.com/ngdhuy/ITEC-2021-AOOP-DemoFileAccess</p>

<p>- StackOverFlow URL: https://stackoverflow.com/questions/45185959/how-to-select-random-items-from-listbox-without-repeating?fbclid=IwAR2BgiTiY4pUPk0KNyupx2nSm2wJDejAcxfey_wrm1aswXgWnrOZpGZOm7I</p>

<p>- Lab04 và Lab08 phần thực hành</p>















