import java.awt.EventQueue;
import java.awt.event.ActionEvent;
import java.awt.event.ActionListener;

import javax.swing.AbstractAction;
import javax.swing.JButton;
import javax.swing.JFrame;
import javax.swing.JLabel;
import javax.swing.JTextField;

public class MainGui implements ActionListener {

	private JFrame frame;
	private JTextField txtRow;
	private JTextField txtColumn;

	public static void main(String[] args) {
		EventQueue.invokeLater(new Runnable() {
			public void run() {
				try {
					MainGui window = new MainGui();
					window.frame.setVisible(true);
				} catch (Exception e) {
					e.printStackTrace();
				}
			}
		});
	}

	/**
	 * Create the application.
	 */
	public MainGui() {
		initialize();
	}

	/**
	 * Initialize the contents of the frame.
	 */
	private void initialize() {
		frame = new JFrame();
		frame.setBounds(40, 20, 370, 282);
		frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
		frame.getContentPane().setLayout(null);

		txtRow = new JTextField();
		txtRow.setBounds(115, 127, 86, 20);
		frame.getContentPane().add(txtRow);
		txtRow.setColumns(10);

		JButton btnStartGame = new JButton("New button");
		btnStartGame.setBounds(115, 198, 89, 23);
		frame.getContentPane().add(btnStartGame);

		txtColumn = new JTextField();
		txtColumn.setBounds(115, 152, 86, 20);
		frame.getContentPane().add(txtColumn);
		txtColumn.setColumns(10);

		JLabel lblRow = new JLabel("Row");
		lblRow.setBounds(45, 130, 46, 14);
		frame.getContentPane().add(lblRow);

		JLabel lblColumn = new JLabel("Column");
		lblColumn.setBounds(45, 155, 46, 14);
		frame.getContentPane().add(lblColumn);

		JLabel label_1 = new JLabel("1 : 30");
		label_1.setBounds(223, 130, 46, 14);
		frame.getContentPane().add(label_1);

		JLabel label_2 = new JLabel("1 : 30");
		label_2.setBounds(223, 155, 46, 14);
		frame.getContentPane().add(label_2);

	}

	private class SwingAction extends AbstractAction {
		public SwingAction() {
			putValue(NAME, "SwingAction");
			putValue(SHORT_DESCRIPTION, "Some short description");
		}

		public void actionPerformed(ActionEvent e) {
		}
	}

	@Override
	public void actionPerformed(ActionEvent e) {
		// TODO Auto-generated method stub

	}

}
