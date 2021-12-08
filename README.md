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

![image](https://user-images.githubusercontent.com/91233366/145055389-25065f1b-e133-470b-bcce-3dffc0162df9.png)

![image](https://user-images.githubusercontent.com/91233366/145055438-534e4521-f750-477b-91fe-e95ad3a736e4.png)

![image](https://user-images.githubusercontent.com/91233366/145055476-f6de4a0b-b230-4b05-bbac-9e014d490c81.png)

2. File XML của Thitracnghiem form
<p>- Có 1 file XML được đặt tên là test chứa đề để dành cho việc kiểm tra, và sẽ không có bất kìa dòng nào chỉ đáp án nhằm tránh gian lận</p>

![image](https://user-images.githubusercontent.com/91233366/145055783-03214520-1194-40d9-8a43-d18a74d37c11.png)

![image](https://user-images.githubusercontent.com/91233366/145055807-4f8f1e4a-b9ec-4973-8e6b-b6ecfef385fe.png)

3. Soandethi-Chamtracnghiem Form
<p>- Ở phần soạn đề, giám thị có thể tự tạo ra 1 đề theo mong muốn bằng cách tự chọn các câu có trong ngân hàng đề được chứ trong file DeThi.xml.</p>

<p>- Đồng thời giám thị cũngg có thể tự tạo 1 đề thi với các câu hỏi ngẫu nhiên chỉ bằng cách cho số lượng câu hỏi mong muốn vào 1 textbox và bấm tạo đề, hệ thống sẽ tự động chọn bất kì câu hỏi tự ngân hàng đề cho tới khi đủ số lượng thì sẽ xuất ra 1 fie xml đề mới.</p>

<p>Form tạo đề</p>
![image](https://user-images.githubusercontent.com/91233366/145057621-7110af84-491a-4fda-88f3-61723f450e0b.png)

<p>Tạo đề ngẫu nhiên bằng cách cho số lượng câu hỏi.</p>
![image](https://user-images.githubusercontent.com/91233366/145057849-8bda71db-8195-43f1-81f2-113b857c1708.png)

<p>- Phần chấm bài</p>
![image](https://user-images.githubusercontent.com/91233366/145060878-a88d1fcf-e336-4b00-885f-41a695b1d158.png)

4. Các file XML có trong Soandethi-Chamtracnghiem Form
<p>Bao gồm file XML tên DeThi chứa ngân hàng đề, khi tạo ra đề sẽ được lưu vào file Test.xml ở phía trên nhằm cho mục đích load đề thi, và 1 file XML bài làm của thí sinh nhằm mục đích chấm bài</p>

<p>ngân hàng đề</p>
![image](https://user-images.githubusercontent.com/91233366/145061460-d265a786-dd5b-4df3-bd56-241eb3627874.png)

<p>File bài làm của thí sinh</p>
![image](https://user-images.githubusercontent.com/91233366/145061543-fe33f7ad-5838-4af4-9558-b60cb4692016.png)

***
**Tự đánh giá chương trình** 
* Điểm mạnh 



* Điểm yếu 

***
**Các nguồn tham khảo**
<p>- Có sự hướng dẫn và giúp đỡ của thầy Nguyễn Đức Huy</p>















